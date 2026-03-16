using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ClearHl7.Extensions;
using ClearHl7.Serialization;
using ClearHl7.V290;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SerializationTests
{
    public class MessageSerializerStreamTests
    {
        private static readonly string ValidMessage =
            $"MSH|^~\\&|Sender 1||Receiver 1||20201202144539|||||2.9{Consts.LineTerminator}" +
            $"PID|1||PAT001{Consts.LineTerminator}";

        // ── SerializeAsync ────────────────────────────────────────────────────────

        /// <summary>
        /// Validates that SerializeAsync writes the HL7 pipehat representation to the destination stream.
        /// </summary>
        [Fact]
        public async Task SerializeAsync_WritesCorrectContent()
        {
            Message message = MessageSerializer.Deserialize<Message>(ValidMessage);
            string expected = message.ToDelimitedString();

            using var stream = new MemoryStream();
            await MessageSerializer.SerializeAsync(message, stream);

            string actual = Encoding.UTF8.GetString(stream.ToArray());
            actual.Should().Be(expected);
        }

        /// <summary>
        /// Validates that SerializeAsync uses the specified encoding when writing to the stream.
        /// </summary>
        [Fact]
        public async Task SerializeAsync_UsesSpecifiedEncoding()
        {
            Message message = MessageSerializer.Deserialize<Message>(ValidMessage);
            Encoding encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

            using var stream = new MemoryStream();
            await MessageSerializer.SerializeAsync(message, stream, encoding);

            // Should be readable back with the same encoding
            string content = encoding.GetString(stream.ToArray());
            content.Should().NotBeNullOrEmpty();
            content.Should().StartWith("MSH");
        }

        /// <summary>
        /// Validates that SerializeAsync leaves the destination stream open after writing.
        /// </summary>
        [Fact]
        public async Task SerializeAsync_LeavesStreamOpen()
        {
            Message message = MessageSerializer.Deserialize<Message>(ValidMessage);

            using var stream = new MemoryStream();
            await MessageSerializer.SerializeAsync(message, stream);

            stream.CanWrite.Should().BeTrue();
        }

        /// <summary>
        /// Validates that SerializeAsync throws ArgumentNullException when message is null.
        /// </summary>
        [Fact]
        public async Task SerializeAsync_NullMessage_ThrowsArgumentNullException()
        {
            using var stream = new MemoryStream();

            Func<Task> act = () => MessageSerializer.SerializeAsync(null, stream);

            await act.Should().ThrowAsync<ArgumentNullException>()
                .WithParameterName("message");
        }

        /// <summary>
        /// Validates that SerializeAsync throws ArgumentNullException when destination is null.
        /// </summary>
        [Fact]
        public async Task SerializeAsync_NullDestination_ThrowsArgumentNullException()
        {
            Message message = MessageSerializer.Deserialize<Message>(ValidMessage);

            Func<Task> act = () => MessageSerializer.SerializeAsync(message, null);

            await act.Should().ThrowAsync<ArgumentNullException>()
                .WithParameterName("destination");
        }

        // ── DeserializeAsync (version-detecting) ─────────────────────────────────

        /// <summary>
        /// Validates that DeserializeAsync correctly deserializes a message from a UTF-8 stream.
        /// </summary>
        [Fact]
        public async Task DeserializeAsync_ReturnsCorrectMessage()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(ValidMessage);
            using var stream = new MemoryStream(bytes);

            IMessage result = await MessageSerializer.DeserializeAsync(stream);

            result.Should().NotBeNull();
            result.Segments.Should().NotBeEmpty();
        }

        /// <summary>
        /// Validates that DeserializeAsync leaves the source stream open after reading.
        /// </summary>
        [Fact]
        public async Task DeserializeAsync_LeavesStreamOpen()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(ValidMessage);
            using var stream = new MemoryStream(bytes);

            await MessageSerializer.DeserializeAsync(stream);

            stream.CanRead.Should().BeTrue();
        }

        /// <summary>
        /// Validates that DeserializeAsync throws ArgumentNullException when source is null.
        /// </summary>
        [Fact]
        public async Task DeserializeAsync_NullSource_ThrowsArgumentNullException()
        {
            Func<Task> act = () => MessageSerializer.DeserializeAsync(null);

            await act.Should().ThrowAsync<ArgumentNullException>()
                .WithParameterName("source");
        }

        // ── DeserializeAsync<T> (strongly-typed) ─────────────────────────────────

        /// <summary>
        /// Validates that DeserializeAsync{T} correctly deserializes a message from a stream into the specified type.
        /// </summary>
        [Fact]
        public async Task DeserializeAsyncGeneric_ReturnsCorrectlyTypedMessage()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(ValidMessage);
            using var stream = new MemoryStream(bytes);

            Message result = await MessageSerializer.DeserializeAsync<Message>(stream);

            result.Should().NotBeNull();
            result.Segments.Should().NotBeEmpty();
        }

        /// <summary>
        /// Validates that DeserializeAsync{T} throws ArgumentNullException when source is null.
        /// </summary>
        [Fact]
        public async Task DeserializeAsyncGeneric_NullSource_ThrowsArgumentNullException()
        {
            Func<Task> act = () => MessageSerializer.DeserializeAsync<Message>(null);

            await act.Should().ThrowAsync<ArgumentNullException>()
                .WithParameterName("source");
        }

        /// <summary>
        /// Validates that round-tripping (serialize then deserialize via streams) produces an equivalent message.
        /// </summary>
        [Fact]
        public async Task RoundTrip_SerializeThenDeserialize_ProducesEquivalentMessage()
        {
            Message original = MessageSerializer.Deserialize<Message>(ValidMessage);

            using var stream = new MemoryStream();
            await MessageSerializer.SerializeAsync(original, stream);

            stream.Position = 0;
            Message roundTripped = await MessageSerializer.DeserializeAsync<Message>(stream);

            roundTripped.ToDelimitedString().Should().Be(original.ToDelimitedString());
        }

        // ── MessageExtensions.SerializeToAsync ────────────────────────────────────

        /// <summary>
        /// Validates that the SerializeToAsync extension method writes the correct content to the stream.
        /// </summary>
        [Fact]
        public async Task SerializeToAsync_Extension_WritesCorrectContent()
        {
            Message message = MessageSerializer.Deserialize<Message>(ValidMessage);
            string expected = message.ToDelimitedString();

            using var stream = new MemoryStream();
            await message.SerializeToAsync(stream);

            string actual = Encoding.UTF8.GetString(stream.ToArray());
            actual.Should().Be(expected);
        }
    }
}
