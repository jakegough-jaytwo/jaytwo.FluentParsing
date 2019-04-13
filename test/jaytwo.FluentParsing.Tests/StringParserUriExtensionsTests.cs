using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserUriExtensionsTests
    {
        private static readonly string TestString = $"https://www.google.com";
        private static readonly Uri TestValue = new Uri(TestString);

        private static readonly string TestStringRelative = $"/home";
        private static readonly Uri TestValueRelative = new Uri(TestStringRelative, UriKind.Relative);

        [Fact]
        public void string_Parse_Uri()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Uri();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Uri_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Uri());
        }

        [Fact]
        public void string_Parse_Uri_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<UriFormatException>(() => data.Parse().Uri());
        }

        [Fact]
        public void string_Parse_Uri_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<UriFormatException>(() => data.Parse().Uri());
        }

        [Fact]
        public void string_Parse_Nullable_Uri()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Nullable().Uri();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Uri_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Uri();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Uri_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Uri();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Uri_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<UriFormatException>(() => data.Parse().Nullable().Uri());
        }

        [Fact]
        public void string_Parse_Try_Uri()
        {
            // arrange            

            // act
            var parsed = TestString.Parse().Try().Uri();

            // assert
            Assert.Equal(TestValue, parsed);
        }

        [Fact]
        public void string_Parse_Try_Uri_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Uri();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Uri_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Uri();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Uri_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Uri();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Uri_relative()
        {
            // arrange            

            // act
            var parsed = TestStringRelative.Parse().Uri(UriKind.Relative);

            // assert
            Assert.Equal(TestValueRelative, parsed);
        }

        [Fact]
        public void string_Parse_Uri_relative_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Uri(UriKind.Relative));
        }

        [Fact]
        public void string_Parse_Uri_relative_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Uri(UriKind.Relative);

            // assert
            Assert.Equal(string.Empty, parsed.ToString());
        }

        [Fact]
        public void string_Parse_Uri_relative_throws_on_text()
        {
            // arrange            
            string data = "http://hello world";

            // act & assert
            Assert.Throws<UriFormatException>(() => data.Parse().Uri(UriKind.Relative));
        }

        [Fact]
        public void string_Parse_Nullable_Uri_relative()
        {
            // arrange            

            // act
            var parsed = TestStringRelative.Parse().Nullable().Uri(UriKind.Relative);

            // assert
            Assert.Equal(TestValueRelative, parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Uri_relative_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Uri(UriKind.Relative);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Uri_relative_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Uri(UriKind.Relative);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Uri_relative_throws_on_text()
        {
            // arrange            
            string data = "http://hello world";

            // act & assert
            Assert.Throws<UriFormatException>(() => data.Parse().Nullable().Uri(UriKind.Relative));
        }

        [Fact]
        public void string_Parse_Try_Uri_relative()
        {
            // arrange            

            // act
            var parsed = TestStringRelative.Parse().Try().Uri(UriKind.Relative);

            // assert
            Assert.Equal(TestValueRelative, parsed);
        }

        [Fact]
        public void string_Parse_Try_Uri_relative_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Uri(UriKind.Relative);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Uri_relative_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Uri(UriKind.Relative);

            // assert
            Assert.Equal(string.Empty, parsed.ToString());
        }

        [Fact]
        public void string_Parse_Try_Uri_relative_ok_on_full_url()
        {
            // arrange            
            string data = "http://hello world";

            // act
            var parsed = data.Parse().Try().Uri(UriKind.Relative);

            // assert
            Assert.Null(parsed);
        }
    }
}
