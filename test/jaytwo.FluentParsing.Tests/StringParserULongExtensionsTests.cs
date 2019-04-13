using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserULongExtensionsTests
    {
        private static readonly string TestString = $"12345";
        private static readonly ulong TestValue = 12345l;

        private static readonly string TestStringCurrency = $"${TestString}";
        private static readonly NumberStyles CurrencyStyle = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;

        [Fact]
        public void string_Parse_ULong()
        {
            // arrange            
            
            // act
            var parsed = TestString.Parse().ULong();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_ULong_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().ULong());
        }

        [Fact]
        public void string_Parse_ULong_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().ULong());
        }

        [Fact]
        public void string_Parse_ULong_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().ULong());
        }

        [Fact]
        public void string_Parse_Nullable_ULong()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().ULong();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_ULong_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().ULong();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_ULong_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().ULong();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_ULong_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().ULong());
        }

        [Fact]
        public void string_Parse_Try_ULong()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().ULong();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_ULong_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().ULong();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_ULong_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().ULong();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_ULong_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().ULong();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_ULong_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().ULong(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_ULong_Currency_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().ULong(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_ULong_Currency_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().ULong(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_ULong_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().ULong(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Nullable_ULong_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Nullable().ULong(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_ULong_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().ULong(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_ULong_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().ULong(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_ULong_Currency_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().ULong(CurrencyStyle));
        }

        [Fact]
        public void string_Parse_Try_ULong_Currency()
        {
            // arrange            

            // act
            var parsed = TestStringCurrency.Parse().Try().ULong(CurrencyStyle);

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_ULong_Currency_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().ULong(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_ULong_Currency_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().ULong(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_ULong_Currency_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().ULong(CurrencyStyle);

            // assert
            Assert.Null(parsed);
        }
    }
}
