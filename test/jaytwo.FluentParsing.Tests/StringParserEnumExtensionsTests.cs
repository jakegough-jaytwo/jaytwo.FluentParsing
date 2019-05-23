using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserEnumExtensionsTests
    {
        [Theory]
        [InlineData("AllowCurrencySymbol", NumberStyles.AllowCurrencySymbol)]
        [InlineData("allowcurrencysymbol", NumberStyles.AllowCurrencySymbol)]
        public void string_Parse_Enum(string data, NumberStyles expected)
        {
            // arrange

            // act
            var parsed = data.Parse().Enum<NumberStyles>();

            // assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void string_Parse_Enum_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Enum<NumberStyles>());
        }

        [Fact]
        public void string_Parse_Enum_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<ArgumentException>(() => data.Parse().Enum<NumberStyles>());
        }

        [Fact]
        public void string_Parse_Enum_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<ArgumentException>(() => data.Parse().Enum<NumberStyles>());
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData("AllowCurrencySymbol", NumberStyles.AllowCurrencySymbol)]
        [InlineData("allowcurrencysymbol", NumberStyles.AllowCurrencySymbol)]
        public void string_Parse_Nullable_Enum(string data, NumberStyles? expected)
        {
            // arrange

            // act
            var parsed = data.Parse().Nullable().Enum<NumberStyles>();

            // assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Enum_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Enum<NumberStyles>();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Enum_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            var parsed = data.Parse().Nullable().Enum<NumberStyles>();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Enum_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<ArgumentException>(() => data.Parse().Nullable().Enum<NumberStyles>());
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData("hello", null)]
        [InlineData("AllowCurrencySymbol", NumberStyles.AllowCurrencySymbol)]
        [InlineData("allowcurrencysymbol", NumberStyles.AllowCurrencySymbol)]
        public void string_Parse_Try_Enum(string data, NumberStyles? expected)
        {
            // arrange

            // act
            var parsed = data.Parse().Try().Enum<NumberStyles>();

            // assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void string_Parse_Try_Enum_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Enum<NumberStyles>();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Enum_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            var parsed = data.Parse().Try().Enum<NumberStyles>();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Enum_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            var parsed = data.Parse().Try().Enum<NumberStyles>();

            // assert
            Assert.Null(parsed);
        }
    }
}
