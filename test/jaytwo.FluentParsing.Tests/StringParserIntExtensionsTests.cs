using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserIntExtensionsTests
    {
        private static readonly string TestString = $"12345";
        private static readonly int TestValue = 12345;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_Int()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Int();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Int_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Int());
        }

        [Fact]
        public void string_Parse_Int_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Int());
        }

        [Fact]
        public void string_Parse_Int_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Int());
        }

        [Fact]
        public void string_Parse_Nullable_Int()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Nullable().Int();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Int_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Int();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Int_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Int();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Int_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Int());
        }

        [Fact]
        public void string_Parse_Try_Int()
        {
            // arrange

            // act
            var parsed = TestString.Parse().Try().Int();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Int_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Int();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Int_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Int();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Int_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Int();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Int_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Int(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Int_Currency_throws_on_null()
        {
            // arrange
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Int(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Int_Currency_throws_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Int(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Int_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Int(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_Int_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Nullable().Int(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Int_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Int(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Int_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Int(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Int_Currency_throws_on_text()
        {
            // arrange
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Int(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_Int_Currency()
        {
            // arrange

            // act
            var parsed = TestStringCurrency.Parse().Try().Int(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Int_Currency_ok_on_null()
        {
            // arrange
            string data = null;

            // act
            var parsed = data.Parse().Try().Int(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Int_Currency_ok_on_empty()
        {
            // arrange
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Int(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Int_Currency_ok_on_text()
        {
            // arrange
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Int(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
