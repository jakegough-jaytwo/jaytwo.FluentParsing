using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserUIntExtensionsTests
    {
        private static readonly string TestString = $"12345";
        private static readonly uint TestValue = 12345;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_UInt()
        {
            // arrange            
            
            // act
            var parsed = TestString.Parse().UInt();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_UInt_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UInt());
        }

        [Fact]
        public void string_Parse_UInt_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UInt());
        }

        [Fact]
        public void string_Parse_UInt_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UInt());
        }

        [Fact]
        public void string_Parse_Nullable_UInt()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().UInt();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UInt_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().UInt();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UInt_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().UInt();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UInt_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().UInt());
        }

        [Fact]
        public void string_Parse_Try_UInt()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().UInt();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_UInt_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().UInt();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UInt_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().UInt();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UInt_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().UInt();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_UInt_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().UInt(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_UInt_Currency_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UInt(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_UInt_Currency_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UInt(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_UInt_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().UInt(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_UInt_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Nullable().UInt(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UInt_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().UInt(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UInt_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().UInt(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_UInt_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().UInt(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_UInt_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Try().UInt(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_UInt_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().UInt(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UInt_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().UInt(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_UInt_Currency_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().UInt(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
