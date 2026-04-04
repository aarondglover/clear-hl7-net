using System;
using BenchmarkDotNet.Attributes;
using ClearHl7.Helpers;

namespace ClearHl7.Benchmarks
{
    /// <summary>
    /// Benchmarks that isolate the field-splitting hot path introduced in
    /// <see cref="FieldIndexer"/>.
    /// </summary>
    /// <remarks>
    /// On <c>net8.0</c>, <see cref="FieldIndexer.SplitFields(string, string[])"/> uses a
    /// <c>ReadOnlySpan&lt;char&gt;</c>-based implementation backed by SIMD-vectorized
    /// <c>MemoryExtensions.Count</c> to pre-size the result array and then a single linear
    /// scan to materialise each field string.
    ///
    /// The <c>SplitFieldsLegacy</c> method recreates the previous direct
    /// <see cref="string.Split(string[], StringSplitOptions)"/> call to provide an
    /// apples-to-apples comparison showing the before / after behaviour.
    /// </remarks>
    [MemoryDiagnoser]
    [SimpleJob]
    public class FieldSplittingBenchmarks
    {
        // A realistic PID segment with 41 fields — the largest commonly encountered segment.
        private const string PidSegmentString =
            "PID|1||12345^^^Hospital&UNI&ISO||Smith^John^A||19800115|M|||123 Main St^^Springfield^IL^62701^USA||555-555-1234|||M||987-65-4321||||||||||||||||||||";

        // A short MSH-style segment — exercises the fast path for smaller field counts.
        private const string MshSegmentString =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9";

        private static readonly string[] FieldSep = { "|" };

        // ------------------------------------------------------------------ //
        //  FieldIndexer paths                                                 //
        // ------------------------------------------------------------------ //

        [Benchmark(Description = "FieldIndexer.SplitFields — PID (41 fields)")]
        public string[] SplitFieldsIndexerPid()
            => FieldIndexer.SplitFields(PidSegmentString, FieldSep);

        [Benchmark(Description = "FieldIndexer.SplitFields — MSH (12 fields)")]
        public string[] SplitFieldsIndexerMsh()
            => FieldIndexer.SplitFields(MshSegmentString, FieldSep);

        // ------------------------------------------------------------------ //
        //  Legacy string.Split() baseline                                     //
        // ------------------------------------------------------------------ //

        [Benchmark(Description = "string.Split — PID (41 fields) — legacy baseline")]
        public string[] SplitLegacyPid()
            => PidSegmentString.Split(FieldSep, StringSplitOptions.None);

        [Benchmark(Description = "string.Split — MSH (12 fields) — legacy baseline")]
        public string[] SplitLegacyMsh()
            => MshSegmentString.Split(FieldSep, StringSplitOptions.None);
    }
}
