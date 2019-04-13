using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserGuidExtensionsTests
    {
        private static readonly string TestString = $"92112a28-f431-4b93-bf9e-73d17a921a80";
        private static readonly Guid TestValue = Guid.Parse(TestString);

        [Fact]
        public void string_Parse_Guid()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Guid();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Guid_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Guid());
        }

        [Fact]
        public void string_Parse_Guid_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Guid());
        }

        [Fact]
        public void string_Parse_Guid_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Guid());
        }

        [Fact]
        public void string_Parse_Nullable_Guid()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().Guid();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Guid_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Guid();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Guid_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Guid();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Guid_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Guid());
        }

        [Fact]
        public void string_Parse_Try_Guid()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().Guid();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Guid_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Guid();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Guid_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Guid();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Guid_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Guid();

            // assert
            Assert.Null(parsed);
        }
    }
}
