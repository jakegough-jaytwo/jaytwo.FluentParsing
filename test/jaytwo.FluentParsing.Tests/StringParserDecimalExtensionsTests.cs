using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserDecimalExtensionsTests
    {
        private static readonly string TestString = $"123.45";
        private static readonly decimal TestValue = 123.45m;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_Decimal()
        {
            // arrange            
            
            // act
            var parsed = TestString.Parse().Decimal();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Decimal_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Decimal());
        }

        [Fact]
        public void string_Parse_Decimal_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Decimal());
        }

        [Fact]
        public void string_Parse_Decimal_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Decimal());
        }

        [Fact]
        public void string_Parse_Nullable_Decimal()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().Decimal();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Decimal();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Decimal();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Decimal());
        }

        [Fact]
        public void string_Parse_Try_Decimal()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().Decimal();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Decimal_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Decimal();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Decimal_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Decimal();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Decimal_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Decimal();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Decimal_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Decimal(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Decimal_Currency_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Decimal(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Decimal_Currency_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Decimal(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Decimal_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Decimal(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Nullable().Decimal(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Decimal(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Decimal(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Decimal_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Decimal(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_Decimal_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Try().Decimal(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Decimal_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Decimal(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Decimal_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Decimal(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Decimal_Currency_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Decimal(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
