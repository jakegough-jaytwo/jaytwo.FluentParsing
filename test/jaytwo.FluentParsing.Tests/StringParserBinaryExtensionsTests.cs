using System;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserBinaryExtensionsTests
    {
        private static readonly string TestBase64String = Convert.ToBase64String(Encoding.UTF8.GetBytes("hello world"));
        private static readonly string TestHexString = BitConverter.ToString(Encoding.UTF8.GetBytes("hello world")).Replace("-", "");
        private static readonly byte[] TestValue = Convert.FromBase64String(TestBase64String);

        [Fact]
        public void string_Parse_Base64()
        {
            // arrange            
            
            // act
            var parsed = TestBase64String.Parse().Base64();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Base64_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Base64());
        }

        [Fact]
        public void string_Parse_Base64_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Base64();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Base64_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Base64());
        }

        [Fact]
        public void string_Parse_Nullable_Base64()
        {
            // arrange            

            // act
            var parsed = TestBase64String.Parse().Nullable().Base64();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Base64_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Base64();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Base64_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Base64();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Base64_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Base64());
        }

        [Fact]
        public void string_Parse_Try_Base64()
        {
            // arrange            

            // act
            var parsed = TestBase64String.Parse().Try().Base64();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Base64_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Base64();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Base64_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Base64();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Try_Base64_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Base64();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Hex()
        {
            // arrange            

            // act
            var parsed = TestHexString.Parse().Hex();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Hex_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Hex());
        }

        [Fact]
        public void string_Parse_Hex_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Hex();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Hex_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Hex());
        }

        [Fact]
        public void string_Parse_Nullable_Hex()
        {
            // arrange            

            // act
            var parsed = TestHexString.Parse().Nullable().Hex();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Hex_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Hex();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Hex_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Hex();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Hex_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Hex());
        }

        [Fact]
        public void string_Parse_Try_Hex()
        {
            // arrange            

            // act
            var parsed = TestHexString.Parse().Try().Hex();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Hex_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Hex();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Hex_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Hex();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void string_Parse_Try_Hex_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Hex();

            // assert
            Assert.Null(parsed);
        }
    }
}
