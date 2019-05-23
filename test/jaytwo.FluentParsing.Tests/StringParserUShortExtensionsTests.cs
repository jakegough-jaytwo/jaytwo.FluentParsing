using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserUShortExtensionsTests
    {
        private static readonly string TestString = $"12345";
        private static readonly ushort TestValue = 12345;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_UShort()
        {
            // arrange

            // act
            var parsed = TestString.Parse().UShort();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_UShort_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UShort());
        }

        [Fact]
        public void string_Parse_UShort_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UShort());
        }

        [Fact]
        public void string_Parse_UShort_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UShort());
        }

        [Fact]
        public void string_Parse_Nullable_UShort()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Nullable().UShort();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UShort_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().UShort();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UShort_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().UShort();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UShort_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().UShort());
        }

        [Fact]
        public void string_Parse_Try_UShort()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Try().UShort();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_UShort_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().UShort();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UShort_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().UShort();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UShort_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().UShort();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_UShort_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().UShort(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_UShort_Currency_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UShort(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_UShort_Currency_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UShort(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_UShort_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UShort(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_UShort_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Nullable().UShort(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UShort_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().UShort(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UShort_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().UShort(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UShort_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().UShort(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_UShort_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Try().UShort(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_UShort_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().UShort(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UShort_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().UShort(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UShort_Currency_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().UShort(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
