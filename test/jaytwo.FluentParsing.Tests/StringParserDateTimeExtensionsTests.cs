using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserDateTimeExtensionsTests
    {
        private static readonly string TestString = $"2019-04-13 00:57:13 AM";
        private static readonly DateTime TestValue = new DateTime(2019, 4, 13, 0, 57, 13);

        [Fact]
        public void string_Parse_DateTime()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().DateTime();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_DateTime_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().DateTime());
        }

        [Fact]
        public void string_Parse_DateTime_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().DateTime());
        }

        [Fact]
        public void string_Parse_DateTime_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().DateTime());
        }

        [Fact]
        public void string_Parse_Nullable_DateTime()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().DateTime();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_DateTime_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().DateTime();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_DateTime_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().DateTime();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_DateTime_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().DateTime());
        }

        [Fact]
        public void string_Parse_Try_DateTime()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().DateTime();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_DateTime_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().DateTime();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_DateTime_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().DateTime();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_DateTime_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().DateTime();

            // assert
            Assert.Null(parsed);
        }
    }
}
