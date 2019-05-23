using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserShortExtensionsTests
    {
        private static readonly string TestString = $"12345";
        private static readonly short TestValue = 12345;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_Short()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Short();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Short_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Short());
        }

        [Fact]
        public void string_Parse_Short_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Short());
        }

        [Fact]
        public void string_Parse_Short_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Short());
        }

        [Fact]
        public void string_Parse_Nullable_Short()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Nullable().Short();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Short_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Short();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Short_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Short();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Short_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Short());
        }

        [Fact]
        public void string_Parse_Try_Short()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Try().Short();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Short_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Short();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Short_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Short();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Short_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Short();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Short_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Short(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Short_Currency_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Short(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Short_Currency_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Short(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Short_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Short(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_Short_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Nullable().Short(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Short_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Short(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Short_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Short(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Short_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Short(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_Short_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Try().Short(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Short_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Short(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Short_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Short(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Short_Currency_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Short(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
