using System;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class ByteArrayParserExtensionsTests
    {
        private static readonly string TestString = "Hello World";
        private static readonly byte[] TestValue = Encoding.UTF8.GetBytes(TestString);
        private static readonly string TestHexString = BitConverter.ToString(TestValue).Replace("-", string.Empty);
        private static readonly string TestBase64String = Convert.ToBase64String(TestValue);

        [Fact]
        public void bytes_Parse_Base64()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Base64();

            // assert
            Assert.Equal(TestBase64String, parsed);
        }

        [Fact]
        public void bytes_Parse_Base64_throws_on_null()
        {
            // arrange
            byte[] data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Base64());
        }

        [Fact]
        public void bytes_Parse_Base64_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Base64();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_Base64()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Nullable().Base64();

            // assert
            Assert.Equal(TestBase64String, parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_Base64_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Nullable().Base64();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_Base64_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Nullable().Base64();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_Base64()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Try().Base64();

            // assert
            Assert.Equal(TestBase64String, parsed);
        }

        [Fact]
        public void bytes_Parse_Try_Base64_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Try().Base64();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_Base64_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Try().Base64();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Hex()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Hex();

            // assert
            Assert.Equal(TestHexString, parsed);
        }

        [Fact]
        public void bytes_Parse_Hex_throws_on_null()
        {
            // arrange
            byte[] data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Hex());
        }

        [Fact]
        public void bytes_Parse_Hex_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Hex();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_Hex()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Nullable().Hex();

            // assert
            Assert.Equal(TestHexString, parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_Hex_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Nullable().Hex();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_Hex_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Nullable().Hex();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_Hex()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Try().Hex();

            // assert
            Assert.Equal(TestHexString, parsed);
        }

        [Fact]
        public void bytes_Parse_Try_Hex_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Try().Hex();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_Hex_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Try().Hex();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_UTF8String()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().UTF8String();

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_UTF8String_throws_on_null()
        {
            // arrange
            byte[] data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UTF8String());
        }

        [Fact]
        public void bytes_Parse_UTF8String_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().UTF8String();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_UTF8String()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Nullable().UTF8String();

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_UTF8String_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Nullable().UTF8String();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_UTF8String_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Nullable().UTF8String();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_UTF8String()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Try().UTF8String();

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Try_UTF8String_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Try().UTF8String();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_UTF8String_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Try().UTF8String();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_String()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().String(Encoding.ASCII);

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_String_throws_on_null()
        {
            // arrange
            byte[] data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().String(Encoding.ASCII));
        }

        [Fact]
        public void bytes_Parse_String_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().String(Encoding.ASCII);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_String()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Nullable().String(Encoding.ASCII);

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_String_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Nullable().String(Encoding.ASCII);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_String_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Nullable().String(Encoding.ASCII);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_String()
        {
            // arrange

            // act
            var parsed = TestValue.Parse().Try().String(Encoding.ASCII);

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Try_String_ok_on_null()
        {
            // arrange
            byte[] data = null;

            // act
            var parsed = data.Parse().Try().String(Encoding.ASCII);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_String_ok_on_empty()
        {
            // arrange
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Try().String(Encoding.ASCII);

            // assert
            Assert.Empty(parsed);
        }
    }
}
