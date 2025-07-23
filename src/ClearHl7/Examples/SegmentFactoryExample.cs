using System;
using System.Linq;
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V281;

namespace ClearHl7.Examples
{
    /// <summary>
    /// Example custom segment implementation as requested in the problem statement.
    /// </summary>
    public class ZdsSegment : ISegment
    {
        public string Id => "ZDS";
        public int Ordinal { get; set; }

        public void FromDelimitedString(string delimitedString) 
        { 
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            // Example implementation - in real use this would parse the segment data
            Console.WriteLine($"Parsing custom ZDS segment: {delimitedString}");
        }

        public string ToDelimitedString() => "ZDS|CUSTOM|SEGMENT|DATA|";
    }

    /// <summary>
    /// Example demonstrating the SegmentFactory usage as specified in the problem statement.
    /// </summary>
    public class SegmentFactoryExample
    {
        public static void RunExample()
        {
            Console.WriteLine("SegmentFactory Custom Segment Registration Example");
            Console.WriteLine("=================================================");

            // Register once at app startup or before parsing:
            SegmentFactory.RegisterSegment<ZdsSegment>("ZDS");   // registers in all versions of hl7

            SegmentFactory.RegisterSegment<Hl7Version, ZdsSegment>("ZDS");   // registers in specific version of hl7 for serializer/deserializer.

            Console.WriteLine("✓ Registered ZdsSegment globally and for specific HL7 versions");

            // Test creating segment directly
            var segment = SegmentFactory.CreateSegment("ZDS");
            Console.WriteLine($"✓ Created segment directly: {segment?.Id}");

            // Test in message parsing context
            string hl7Message = 
                "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DESTINATION|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                "ZDS|CUSTOM|SEGMENT|DATA|\r";

            Console.WriteLine("\nParsing HL7 message with custom ZDS segment:");
            var message = MessageSerializer.Deserialize<Message>(hl7Message);
            
            Console.WriteLine($"✓ Parsed message with {message.Segments.Count()} segments");
            
            var zdsSegment = message.Segments.FirstOrDefault(s => s.Id == "ZDS");
            Console.WriteLine($"✓ Found custom segment: {zdsSegment?.Id}");
            Console.WriteLine($"✓ Segment type: {zdsSegment?.GetType().Name}");

            Console.WriteLine("\nExample completed successfully!");
        }
    }
}