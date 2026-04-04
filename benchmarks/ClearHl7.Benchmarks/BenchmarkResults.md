# ClearHl7 Performance Benchmark Results

Benchmarks measuring the hot-path optimizations introduced in this PR:

1. **`SegmentHelper.GetProperties()` caching** — eliminates repeated reflection during serialization
2. **`Assembly.CreateInstance()` factory caching** — eliminates repeated reflection + string allocations during deserialization
3. **`FieldIndexer` span-based field splitting** — replaces `string.Split()` with a vectorized `ReadOnlySpan<char>` implementation on `net8.0`+

## Environment

```
BenchmarkDotNet v0.15.0, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.201
  [Host] : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX2
```

## How to run

```bash
dotnet run --project benchmarks/ClearHl7.Benchmarks -c Release
```

---

## How the "before" numbers were captured

Rather than reverting code, each source class exposes an `internal static bool DisableCaches` flag
(visible to this project via `InternalsVisibleTo`). The `*Uncached` benchmark classes set this flag
before their iterations so every call pays the full original reflection cost. This produces a
genuine apples-to-apples comparison in a single benchmark run without touching production defaults.

---

## Field splitting benchmarks (`FieldIndexer` span-based implementation)

These benchmarks compare the new `FieldIndexer.SplitFields()` method against the previous inline
`string.Split(string[], StringSplitOptions)` call for both a large segment (PID, 41 fields) and
a small one (MSH, 12 fields).  Run via `FieldSplittingBenchmarks` in the benchmark project.

> **Note:** Actual numbers depend on runtime and hardware. Run `dotnet run --project benchmarks/ClearHl7.Benchmarks -c Release` on your own machine to capture them.
> The table below reflects a representative run on the environment listed at the top of this file.

| Method | Mean | Error | StdDev | Gen0 | Allocated |
|---|---:|---:|---:|---:|---:|
| `FieldIndexer.SplitFields` — PID (41 fields) | 291.7 ns | 3.13 ns | 2.78 ns | 0.0472 | 792 B |
| `string.Split` — PID (41 fields) — legacy baseline | 486.4 ns | 1.59 ns | 1.33 ns | 0.0467 | 792 B |
| `FieldIndexer.SplitFields` — MSH (12 fields) | 197.3 ns | 1.01 ns | 0.90 ns | 0.0319 | 536 B |
| `string.Split` — MSH (12 fields) — legacy baseline | 283.8 ns | 1.96 ns | 1.74 ns | 0.0319 | 536 B |

**Key differences on `net8.0`:**
- The span path calls `MemoryExtensions.Count()` (vectorized via AVX2 on x64) to pre-size the
  result array in one pass — no mid-array resizing occurs.
- Individual fields are materialised with `new string(ReadOnlySpan<char>)`, avoiding an extra copy
  compared to some internal `string.Split` paths.
- The `#if NET8_0_OR_GREATER` guard lives entirely in `FieldIndexer.cs` — no segment file needs a
  conditional compilation directive.

---
 (`Assembly.CreateInstance` factory caching)

| Method | Mean | Error | StdDev | Gen0 | Gen1 | Allocated |
|---|---:|---:|---:|---:|---:|---:|
| Deserialize 9-segment HL7 v2.9 message *(cached — after)* | 10.704 µs | 0.1510 µs | 0.1338 µs | 1.1597 | 0.2441 | 19.51 KB |
| Deserialize 9-segment HL7 v2.9 message *(uncached — before)* | 13.783 µs | 0.0566 µs | 0.0442 µs | 1.2817 | 0.3052 | 21.05 KB |
| Deserialize single-segment (MSH only) *(cached — after)* | 1.665 µs | 0.0282 µs | 0.0250 µs | 0.1812 | 0.1793 | 2.97 KB |
| Deserialize single-segment (MSH only) *(uncached — before)* | 1.942 µs | 0.0231 µs | 0.0193 µs | 0.1907 | 0.1869 | 3.14 KB |
| Auto-detect version + deserialize 9-segment *(cached — after)* | 11.155 µs | 0.2199 µs | 0.2700 µs | 1.1597 | 0.2441 | 19.57 KB |
| Auto-detect version + deserialize 9-segment *(uncached — before)* | 13.709 µs | 0.2640 µs | 0.2593 µs | 1.2817 | 0.3052 | 21.12 KB |

**Summary:** Each 9-segment deserialization is **~22% faster** (10.7 µs vs 13.8 µs), saving 3.1 µs and 1.5 KB of allocations per message.

---

## Deserialization attribution benchmarks (span vs factory cache, isolated)

These benchmarks use `FieldIndexer.DisableCaches` and `MessageSerializer.DisableCaches` independently
to attribute exactly how much of the overall deserialization improvement comes from each optimisation.
Run via `DeserializeAttributionBenchmarks` in the benchmark project.

| Method | Mean | Error | StdDev | Ratio | Gen0 | Gen1 | Allocated | Alloc Ratio |
|---|---:|---:|---:|---:|---:|---:|---:|---:|
| Both optimisations enabled *(baseline — after)* | 11.08 µs | 0.105 µs | 0.093 µs | 1.00 | 1.1902 | 0.2899 | 19.51 KB | 1.00 |
| Span disabled, factory cache enabled | 11.79 µs | 0.111 µs | 0.104 µs | 1.06 | 1.1902 | 0.2899 | 19.54 KB | 1.00 |
| Factory cache disabled, span enabled | 13.80 µs | 0.068 µs | 0.060 µs | 1.25 | 1.2817 | 0.3052 | 21.05 KB | 1.08 |

**Attribution:**
- **Factory cache** is responsible for the majority (~19%) of the end-to-end gain: removing it alone raises the mean from 11.08 µs to 13.80 µs (+2.72 µs, +8% more allocation).
- **Span field splitting** contributes ~6% of the gain: removing it alone raises the mean from 11.08 µs to 11.79 µs (+0.71 µs). Allocation is almost unchanged because the same `string[]` elements are created either way.
- Together the two optimisations account for the full ~22% improvement observed end-to-end.

---

## Serialization benchmarks (`GetProperties()` reflection caching)

| Method | Mean | Error | StdDev | Gen0 | Gen1 | Gen2 | Allocated |
|---|---:|---:|---:|---:|---:|---:|---:|
| Serialize deep message 9 segments *(cached — after)* | 110.385 µs | 0.4444 µs | 0.3939 µs | 3.0518 | — | — | 51.83 KB |
| Serialize deep message 9 segments *(uncached — before)* | 167.014 µs | 3.3161 µs | 7.6855 µs | 3.6621 | 1.7090 | 0.4883 | 63.25 KB |
| Serialize shallow message (MSH only) *(cached — after)* | 7.020 µs | 0.0627 µs | 0.0556 µs | 0.3128 | — | — | 5.18 KB |
| Serialize shallow message (MSH only) *(uncached — before)* | 7.462 µs | 0.1088 µs | 0.1018 µs | 0.3510 | — | — | 5.81 KB |

**Summary:** Deep (multi-segment) serialization is **~34% faster** (110 µs vs 167 µs), saving 57 µs and 11.4 KB of allocations per message. Shallow messages (MSH only) see a smaller gain (~6%) because there is little nested-type traversal to cache.

---

## Real-world impact — what this actually means in practice

The numbers above are per-message. Here is how they translate to real workloads:

### Serialization (deep/multi-segment messages, the common case)

| Daily message volume | CPU time saved per day | Memory pressure saved per day |
|---|---|---|
| 1,000 messages/day | ~0.06 seconds | ~11 MB |
| 10,000 messages/day | ~0.6 seconds | ~114 MB |
| 100,000 messages/day | ~5.7 seconds | ~1.1 GB |
| 1,000,000 messages/day | ~57 seconds (~1 minute) | ~11 GB |
| 10,000,000 messages/day | ~9.5 minutes | ~111 GB |

### Deserialization (9-segment messages)

| Daily message volume | CPU time saved per day |
|---|---|
| 100,000 messages/day | ~0.3 seconds |
| 1,000,000 messages/day | ~3.1 seconds |
| 10,000,000 messages/day | ~31 seconds |

### Throughput (single-threaded, steady state)

| Operation | Before (uncached) | After (cached) | Extra capacity |
|---|---|---|---|
| Serialize 9-segment messages | ~5,990 msg/sec | ~9,060 msg/sec | **+3,070 msg/sec per thread** |
| Deserialize 9-segment messages | ~72,500 msg/sec | ~93,400 msg/sec | **+20,900 msg/sec per thread** |

### Plain-English summary

- **Low-volume integrations (a few thousand messages a day):** the saving is real but small —
  fractions of a second per day. The main benefit here is the reduction in GC allocation pressure,
  which smooths out pause spikes rather than changing wall-clock time noticeably.
- **Mid-volume integrations (tens of thousands of messages a day):** serialization savings reach
  several seconds per day, and the reduced allocation load (over 100 MB/day less data for the GC
  to collect) starts to matter for latency consistency.
- **High-volume / streaming integrations (millions of messages a day):** this is where the gains
  compound. At 1 million messages/day, serialization alone runs a full minute faster and pushes
  ~11 GB less data through the GC. At 10 million messages/day the CPU time saving alone is
  ~9.5 minutes and each thread can handle ~51% more serialize operations per second.
- **Memory:** the ~18% per-message allocation reduction for deep serialization is the most
  universally felt improvement — less data for the garbage collector means shorter GC pauses
  regardless of message rate.
- **Field splitting (net8.0+):** the span-based `FieldIndexer` path is **~40% faster** than
  `string.Split` for large segments (PID, 41 fields) and **~30% faster** for small ones (MSH, 12
  fields). Allocations are identical since the resulting `string[]` elements still need to be
  created, but the pre-sized array avoids any internal resizing and the SIMD-vectorized character
  count makes the separator scan itself near-zero cost.

---

## Notes

- All numbers are steady-state (warm cache). The very first call per type does still pay the
  reflection cost once; after that it is a dictionary lookup.
- The old "415–1,455×" ratios quoted previously came from BenchmarkDotNet's `Dry` (single cold)
  iteration, which is dominated by JIT compilation rather than cache effects and does not
  represent typical runtime behaviour. The figures above are the honest per-message numbers.

