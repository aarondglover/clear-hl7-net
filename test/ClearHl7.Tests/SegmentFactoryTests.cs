using System;
using ClearHl7;
using ClearHl7.Serialization;
using ClearHl7.V281;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests
{
    public class SegmentFactoryTests
    {
        public SegmentFactoryTests()
        {
            // Clear registrations before each test
            SegmentFactory.ClearRegistrations();
        }

        [Fact]
        public void RegisterSegment_WithValidSegment_RegistersGlobally()
        {
            // Act
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");

            // Assert
            SegmentFactory.GetGlobalRegistrations().Should().Contain("ZDS");
            
            ISegment segment = SegmentFactory.CreateSegment("ZDS");
            segment.Should().NotBeNull();
            segment.Should().BeOfType<TestZdsSegment>();
            segment.Id.Should().Be("ZDS");
        }

        [Fact]
        public void RegisterSegment_WithVersionSpecific_RegistersForSpecificVersion()
        {
            // Act
            SegmentFactory.RegisterSegment<TestZdsSegment>(Hl7Version.V281, "ZDS");

            // Assert
            SegmentFactory.GetVersionRegistrations().Should().Contain("V281|ZDS");
            
            ISegment segment = SegmentFactory.CreateSegment("ZDS", Hl7Version.V281);
            segment.Should().NotBeNull();
            segment.Should().BeOfType<TestZdsSegment>();
            segment.Id.Should().Be("ZDS");
        }

        [Fact]
        public void RegisterSegment_WithGenericVersionTypeApi_RegistersForAllVersions()
        {
            // Act - This tests the API: RegisterSegment<HL7Version, ZdsSegment>("ZDS")
            SegmentFactory.RegisterSegment<Hl7Version, TestZdsSegment>("ZDS");

            // Assert - Should be registered for all HL7 versions
            var registrations = SegmentFactory.GetVersionRegistrations();
            registrations.Should().Contain("V281|ZDS");
            registrations.Should().Contain("V290|ZDS");
            registrations.Should().Contain("V280|ZDS");
            
            ISegment segment = SegmentFactory.CreateSegment("ZDS", Hl7Version.V281);
            segment.Should().NotBeNull();
            segment.Should().BeOfType<TestZdsSegment>();
            segment.Id.Should().Be("ZDS");
        }

        [Fact]
        public void RegisterSegment_WithNullSegmentId_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>(null);
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment ID cannot be null or empty.*");
        }

        [Fact]
        public void RegisterSegment_WithEmptySegmentId_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>("");
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment ID cannot be null or empty.*");
        }

        [Fact]
        public void RegisterSegment_WithInvalidSegmentIdLength_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>("ZDSS");
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment ID must be exactly 3 characters.*");
        }

        [Fact]
        public void RegisterSegment_WithMismatchedSegmentId_ThrowsArgumentException()
        {
            // Act & Assert
            Action act = () => SegmentFactory.RegisterSegment<TestZdsSegment>("ABC");
            act.Should().Throw<ArgumentException>()
                .WithMessage("Segment type TestZdsSegment returns Id 'ZDS' but was registered with ID 'ABC'.*");
        }

        [Fact]
        public void CreateSegment_WithUnregisteredSegment_ReturnsNull()
        {
            // Act
            ISegment segment = SegmentFactory.CreateSegment("XYZ");

            // Assert
            segment.Should().BeNull();
        }

        [Fact]
        public void CreateSegment_WithInvalidSegmentId_ReturnsNull()
        {
            // Act & Assert
            SegmentFactory.CreateSegment(null).Should().BeNull();
            SegmentFactory.CreateSegment("").Should().BeNull();
            SegmentFactory.CreateSegment("AB").Should().BeNull();
            SegmentFactory.CreateSegment("ABCD").Should().BeNull();
        }

        [Fact]
        public void CreateSegment_VersionSpecificTakesPrecedenceOverGlobal()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            SegmentFactory.RegisterSegment<TestZdsV2Segment>(Hl7Version.V281, "ZDS");

            // Act
            ISegment globalSegment = SegmentFactory.CreateSegment("ZDS");
            ISegment versionSegment = SegmentFactory.CreateSegment("ZDS", Hl7Version.V281);

            // Assert
            globalSegment.Should().BeOfType<TestZdsSegment>();
            versionSegment.Should().BeOfType<TestZdsV2Segment>();
        }

        [Fact]
        public void CreateSegment_CaseInsensitive()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");

            // Act & Assert
            SegmentFactory.CreateSegment("zds").Should().NotBeNull();
            SegmentFactory.CreateSegment("Zds").Should().NotBeNull();
            SegmentFactory.CreateSegment("ZDS").Should().NotBeNull();
        }

        [Fact]
        public void ClearRegistrations_RemovesAllRegistrations()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            SegmentFactory.RegisterSegment<TestAbcSegment>(Hl7Version.V281, "ABC");

            // Act
            SegmentFactory.ClearRegistrations();

            // Assert
            SegmentFactory.GetGlobalRegistrations().Should().BeEmpty();
            SegmentFactory.GetVersionRegistrations().Should().BeEmpty();
            SegmentFactory.CreateSegment("ZDS").Should().BeNull();
            SegmentFactory.CreateSegment("ABC", Hl7Version.V281).Should().BeNull();
        }

        [Fact]
        public void Integration_CustomSegmentInMessageParsing()
        {
            // Arrange
            SegmentFactory.RegisterSegment<TestZdsSegment>("ZDS");
            
            string hl7Message = "MSH|^~\\&|SYSTEM|SENDER|RECEIVER|DESTINATION|20240101120000||ADT^A01|MSG001|P|2.8.1||||\r" +
                               "ZDS|CUSTOM|DATA|HERE|\r";

            // Act
            var message = MessageSerializer.Deserialize<Message>(hl7Message);

            // Assert
            message.Should().NotBeNull();
            message.Segments.Should().HaveCount(2);
            
            var zdsSegment = message.Segments.Should().ContainSingle(s => s.Id == "ZDS").Subject;
            zdsSegment.Should().BeOfType<TestZdsSegment>();
            
            var testZds = (TestZdsSegment)zdsSegment;
            testZds.CustomData.Should().Be("|CUSTOM|DATA|HERE|");
        }
    }

    /// <summary>
    /// Test segment for unit testing purposes.
    /// </summary>
    public class TestZdsSegment : ISegment
    {
        public string Id => "ZDS";
        public int Ordinal { get; set; }
        public string CustomData { get; private set; } = string.Empty;

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            if (string.IsNullOrEmpty(delimitedString))
                throw new ArgumentException("Delimited string cannot be null or empty.");

            if (!delimitedString.StartsWith("ZDS"))
                throw new ArgumentException("Delimited string does not begin with ZDS segment.");

            // Store the part after the segment ID for testing
            if (delimitedString.Length > 3)
                CustomData = delimitedString.Substring(3);
        }

        public string ToDelimitedString()
        {
            return $"ZDS{CustomData}";
        }
    }

    /// <summary>
    /// Alternative test segment for version-specific testing.
    /// </summary>
    public class TestZdsV2Segment : ISegment
    {
        public string Id => "ZDS";
        public int Ordinal { get; set; }

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            // Minimal implementation for testing
        }

        public string ToDelimitedString()
        {
            return "ZDS|V2|";
        }
    }

    /// <summary>
    /// Test segment with ABC ID for testing.
    /// </summary>
    public class TestAbcSegment : ISegment
    {
        public string Id => "ABC";
        public int Ordinal { get; set; }

        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            // Minimal implementation for testing
        }

        public string ToDelimitedString()
        {
            return "ABC||";
        }
    }
}