using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserLongExtensionsTests
    {
        private static readonly string TestString = $"12345";
        private static readonly long TestValue = 12345L;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_Long()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Long();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Long_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Long());
        }

        [Fact]
        public void string_Parse_Long_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Long());
        }

        [Fact]
        public void string_Parse_Long_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Long());
        }

        [Fact]
        public void string_Parse_Nullable_Long()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Nullable().Long();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Long_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Long();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Long_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Long();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Long_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Long());
        }

        [Fact]
        public void string_Parse_Try_Long()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Try().Long();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Long_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Long();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Long_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Long();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Long_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Long();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Long_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Long(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Long_Currency_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Long(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Long_Currency_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Long(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Long_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Long(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_Long_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Nullable().Long(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Long_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Long(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Long_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Long(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Long_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Long(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_Long_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Try().Long(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Long_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Long(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Long_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Long(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Long_Currency_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Long(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
