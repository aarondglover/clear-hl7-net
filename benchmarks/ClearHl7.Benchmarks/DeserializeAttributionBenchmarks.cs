using BenchmarkDotNet.Attributes;
using ClearHl7;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.Benchmarks
{
    /// <summary>
    /// Isolates the individual contribution of each optimisation to end-to-end
    /// 9-segment HL7 v2.9 message deserialization performance.
    ///
    /// Three variants are measured so that the improvement from the span-based
    /// <see cref="FieldIndexer"/> and the segment-factory cache can be attributed
    /// independently rather than only as a combined total:
    ///
    /// <list type="bullet">
    ///   <item><b>BothEnabled</b> — all optimisations active; the "after" baseline.</item>
    ///   <item><b>SpanDisabled</b> — factory cache on, span path off (falls back to
    ///     <c>string.Split</c>).  Measures the factory-cache benefit alone.</item>
    ///   <item><b>FactoryCacheDisabled</b> — span path on, factory cache off.  Measures
    ///     the span-field-splitting benefit alone.</item>
    /// </list>
    ///
    /// Comparing <b>BothEnabled</b> vs <b>SpanDisabled</b> shows the span-path saving.
    /// Comparing <b>BothEnabled</b> vs <b>FactoryCacheDisabled</b> shows the factory-cache saving.
    /// </summary>
    [MemoryDiagnoser]
    [SimpleJob]
    public class DeserializeAttributionBenchmarks
    {
        private const string Hl7MultiSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r" +
            "EVN||20201202144539\r" +
            "PID|1||12345^^^Hospital&UNI&ISO||Smith^John^A||19800115|M|||123 Main St^^Springfield^IL^62701^USA||555-555-1234|||M||987-65-4321\r" +
            "PV1|1|I|2WEST^201^1^HOSPITAL||||ATTEND^Doctor^Attending|||SUR||||ADM|A0\r" +
            "IN1|1|BCBS001|Blue Cross|PO Box 100^^Chicago^IL^60601|||||||20200101|20201231\r" +
            "AL1|1|DA|PENICILLIN|MO|Rash\r" +
            "DG1|1||I10^Essential hypertension^ICD-10|Essential hypertension||W\r" +
            "GT1|1||Jones^Mary^^Mrs.||100 Oak Ave^^Springfield^IL^62702||555-234-5678||19551010|F\r" +
            "NK1|1|Smith^Jane^B|SPO|456 Elm St^^Springfield^IL^62703|555-987-6543\r";

        // ------------------------------------------------------------------ //
        //  Both optimisations enabled — "after" baseline                      //
        // ------------------------------------------------------------------ //

        [Benchmark(Baseline = true, Description = "Deserialize 9-segment — both optimisations enabled")]
        public V290.Message BothEnabled()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
        }

        // ------------------------------------------------------------------ //
        //  Span path disabled, factory cache still enabled                    //
        //  → isolates the factory-cache contribution                          //
        // ------------------------------------------------------------------ //

        [GlobalSetup(Target = nameof(SpanDisabled))]
        public void SetupSpanDisabled()
        {
            FieldIndexer.DisableCaches = true;
            MessageSerializer.DisableCaches = false;
        }

        [GlobalCleanup(Target = nameof(SpanDisabled))]
        public void CleanupSpanDisabled()
        {
            FieldIndexer.DisableCaches = false;
        }

        [Benchmark(Description = "Deserialize 9-segment — span disabled, factory cache enabled")]
        public V290.Message SpanDisabled()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
        }

        // ------------------------------------------------------------------ //
        //  Factory cache disabled, span path still enabled                    //
        //  → isolates the span field-splitting contribution                   //
        // ------------------------------------------------------------------ //

        [GlobalSetup(Target = nameof(FactoryCacheDisabled))]
        public void SetupFactoryCacheDisabled()
        {
            FieldIndexer.DisableCaches = false;
            MessageSerializer.DisableCaches = true;
        }

        [GlobalCleanup(Target = nameof(FactoryCacheDisabled))]
        public void CleanupFactoryCacheDisabled()
        {
            MessageSerializer.DisableCaches = false;
        }

        [Benchmark(Description = "Deserialize 9-segment — factory cache disabled, span enabled")]
        public V290.Message FactoryCacheDisabled()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
        }
    }
}
