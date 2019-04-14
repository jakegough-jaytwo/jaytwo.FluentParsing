using System;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserBinaryExtensionsTests
    {
        private static readonly string TestString = "Hello World";
        private static readonly string TestBase64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(TestString));
        private static readonly string TestHexString = BitConverter.ToString(Encoding.UTF8.GetBytes(TestString)).Replace("-", "");
        private static readonly byte[] TestValue = Convert.FromBase64String(TestBase64String);

        [Fact]
        public void string_Parse_Bytes()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Bytes(Encoding.UTF8);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Bytes_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Bytes(Encoding.UTF8));
        }

        [Fact]
        public void string_Parse_Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Bytes(Encoding.UTF8);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Bytes()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().Bytes(Encoding.UTF8);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Bytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Bytes(Encoding.UTF8);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Bytes(Encoding.UTF8);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Try_Bytes()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().Bytes(Encoding.UTF8);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Bytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Bytes(Encoding.UTF8);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Bytes(Encoding.UTF8);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_UTF8Bytes()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().UTF8Bytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_UTF8Bytes_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UTF8Bytes());
        }

        [Fact]
        public void string_Parse_UTF8Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().UTF8Bytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UTF8Bytes()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().UTF8Bytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UTF8Bytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().UTF8Bytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UTF8Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().UTF8Bytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Try_UTF8Bytes()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().UTF8Bytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_UTF8Bytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().UTF8Bytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UTF8Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().UTF8Bytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Base64Bytes()
        {
            // arrange            
            
            // act
            var parsed = TestBase64String.Parse().Base64Bytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Base64Bytes_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Base64Bytes());
        }

        [Fact]
        public void string_Parse_Base64Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Base64Bytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Base64Bytes_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Base64Bytes());
        }

        [Fact]
        public void string_Parse_Nullable_Base64Bytes()
        {
            // arrange            

            // act
            var parsed = TestBase64String.Parse().Nullable().Base64Bytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Base64Bytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Base64Bytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Base64Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Base64Bytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Base64Bytes_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Base64Bytes());
        }

        [Fact]
        public void string_Parse_Try_Base64Bytes()
        {
            // arrange            

            // act
            var parsed = TestBase64String.Parse().Try().Base64Bytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Base64Bytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Base64Bytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Base64Bytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Base64Bytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Try_Base64Bytes_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Base64Bytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_HexBytes()
        {
            // arrange            

            // act
            var parsed = TestHexString.Parse().HexBytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_HexBytes_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().HexBytes());
        }

        [Fact]
        public void string_Parse_HexBytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().HexBytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_HexBytes_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().HexBytes());
        }

        [Fact]
        public void string_Parse_Nullable_HexBytes()
        {
            // arrange            

            // act
            var parsed = TestHexString.Parse().Nullable().HexBytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_HexBytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().HexBytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_HexBytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().HexBytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_HexBytes_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().HexBytes());
        }

        [Fact]
        public void string_Parse_Try_HexBytes()
        {
            // arrange            

            // act
            var parsed = TestHexString.Parse().Try().HexBytes();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_HexBytes_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().HexBytes();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_HexBytes_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().HexBytes();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Try_HexBytes_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().HexBytes();

            // assert
            Assert.Null(parsed);
        }
    }
}
