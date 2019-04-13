using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserDoubleExtensionsTests
    {
        private static readonly string TestString = $"123.45";
        private static readonly double TestValue = 123.45;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_Double()
        {
            // arrange            
            
            // act
            var parsed = TestString.Parse().Double();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Double_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Double());
        }

        [Fact]
        public void string_Parse_Double_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Double());
        }

        [Fact]
        public void string_Parse_Double_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Double());
        }

        [Fact]
        public void string_Parse_Nullable_Double()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().Double();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Double_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Double();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Double_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Double();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Double_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Double());
        }

        [Fact]
        public void string_Parse_Try_Double()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().Double();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Double_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Double();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Double_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Double();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Double_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Double();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Double_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Double(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Double_Currency_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Double(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Double_Currency_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Double(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Double_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Double(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_Double_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Nullable().Double(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Double_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Double(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Double_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Double(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Double_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Double(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_Double_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Try().Double(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Double_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Double(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Double_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Double(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Double_Currency_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Double(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
