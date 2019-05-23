using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserFloatExtensionsTests
    {
        private static readonly string TestString = $"123.45";
        private static readonly float TestValue = 123.45f;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_Float()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Float();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Float_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Float());
        }

        [Fact]
        public void string_Parse_Float_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Float());
        }

        [Fact]
        public void string_Parse_Float_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Float());
        }

        [Fact]
        public void string_Parse_Nullable_Float()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Nullable().Float();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Float_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Float();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Float_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Float();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Float_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Float());
        }

        [Fact]
        public void string_Parse_Try_Float()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Try().Float();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Float_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Float();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Float_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Float();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Float_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Float();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Float_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Float(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Float_Currency_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Float(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Float_Currency_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Float(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Float_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Float(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_Float_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Nullable().Float(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Float_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Float(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Float_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Float(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Float_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Float(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_Float_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Try().Float(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Float_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Float(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Float_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Float(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Float_Currency_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Float(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
