using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserBigIntegerExtensionsTests
    {
        private static readonly string TestString = $"{int.MaxValue}0";
        private static readonly BigInteger TestValue = BigInteger.Parse(TestString);

        private static readonly string TestStringCurrency = $"${TestString}";

        [Fact]
        public void string_Parse_BigInteger()
        {
            // arrange

            // act
            var parsed = TestString.Parse().BigInteger();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_BigInteger_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().BigInteger());
        }

        [Fact]
        public void string_Parse_BigInteger_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().BigInteger());
        }

        [Fact]
        public void string_Parse_BigInteger_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().BigInteger());
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Nullable().BigInteger();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().BigInteger();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().BigInteger();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().BigInteger());
        }

        [Fact]
        public void string_Parse_Try_BigInteger()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Try().BigInteger();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_BigInteger_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().BigInteger();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_BigInteger_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().BigInteger();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_BigInteger_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().BigInteger();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_BigInteger_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_BigInteger_Currency_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().BigInteger(NumberStyles.AllowCurrencySymbol));
        }

        [Fact]
        public void string_Parse_BigInteger_Currency_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().BigInteger(NumberStyles.AllowCurrencySymbol));
        }

        [Fact]
        public void string_Parse_BigInteger_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().BigInteger(NumberStyles.AllowCurrencySymbol));
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Nullable().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_BigInteger_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().BigInteger(NumberStyles.AllowCurrencySymbol));
        }

        [Fact]
        public void string_Parse_Try_BigInteger_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Try().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_BigInteger_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_BigInteger_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_BigInteger_Currency_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().BigInteger(NumberStyles.AllowCurrencySymbol);

            // assert
            Assert.Null(parsed);
        }
    }
}
