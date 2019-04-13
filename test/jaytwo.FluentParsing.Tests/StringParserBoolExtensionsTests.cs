using System;
using System.Numerics;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class StringParserBoolExtensionsTests
    {
        [Theory]
        [InlineData("true")]
        [InlineData("True")]
        [InlineData("TRUE")]
        public void string_Parse_Bool_true(string data)
        {
            // arrange            
            
            // act
            var parsed = data.Parse().Bool();

            // assert
            Assert.True(parsed);
        }

        [Theory]
        [InlineData("false")]
        [InlineData("False")]
        [InlineData("FALSE")]
        public void string_Parse_Bool_false(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Bool();

            // assert
            Assert.False(parsed);
        }

        [Fact]
        public void string_Parse_Bool_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().Bool());
        }

        [Fact]
        public void string_Parse_Bool_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Bool());
        }

        [Fact]
        public void string_Parse_Bool_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Bool());
        }

        [Theory]
        [InlineData("true")]
        [InlineData("True")]
        [InlineData("TRUE")]
        public void string_Parse_Nullable_Bool_true(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Nullable().Bool();

            // assert
            Assert.True(parsed);
        }

        [Theory]
        [InlineData("false")]
        [InlineData("False")]
        [InlineData("FALSE")]
        public void string_Parse_Nullable_Bool_false(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Nullable().Bool();

            // assert
            Assert.False(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Bool_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().Bool();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Bool_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().Bool();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_Bool_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().Bool());
        }

        [Theory]
        [InlineData("true")]
        [InlineData("True")]
        [InlineData("TRUE")]
        public void string_Parse_Try_Bool_true(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Try().Bool();

            // assert
            Assert.True(parsed);
        }

        [Theory]
        [InlineData("false")]
        [InlineData("False")]
        [InlineData("FALSE")]
        public void string_Parse_Try_Bool_false(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Try().Bool();

            // assert
            Assert.False(parsed);
        }

        [Fact]
        public void string_Parse_Try_Bool_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().Bool();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Bool_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().Bool();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_Bool_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().Bool();

            // assert
            Assert.Null(parsed);
        }

        [Theory]
        [InlineData("yes")]
        [InlineData("Yes")]
        [InlineData("YES")]
        [InlineData("Y")]
        [InlineData("y")]
        public void string_Parse_YesNo_true(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().YesNo();

            // assert
            Assert.True(parsed);
        }

        [Theory]
        [InlineData("no")]
        [InlineData("No")]
        [InlineData("NO")]
        [InlineData("N")]
        [InlineData("n")]
        public void string_Parse_YesNo_false(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().YesNo();

            // assert
            Assert.False(parsed);
        }

        [Fact]
        public void string_Parse_YesNo_throws_on_null()
        {
            // arrange            
            string data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().YesNo());
        }

        [Fact]
        public void string_Parse_YesNo_throws_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().YesNo());
        }

        [Fact]
        public void string_Parse_YesNo_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().YesNo());
        }

        [Theory]
        [InlineData("yes")]
        [InlineData("Yes")]
        [InlineData("YES")]
        [InlineData("Y")]
        [InlineData("y")]
        public void string_Parse_Nullable_YesNo_true(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Nullable().YesNo();

            // assert
            Assert.True(parsed);
        }

        [Theory]
        [InlineData("no")]
        [InlineData("No")]
        [InlineData("NO")]
        [InlineData("N")]
        [InlineData("n")]
        public void string_Parse_Nullable_YesNo_false(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Nullable().YesNo();

            // assert
            Assert.False(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_YesNo_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Nullable().YesNo();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_YesNo_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Nullable().YesNo();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Nullable_YesNo_throws_on_text()
        {
            // arrange            
            string data = "hello world";

            // act & assert
            Assert.Throws<FormatException>(() => data.Parse().Nullable().YesNo());
        }

        [Theory]
        [InlineData("yes")]
        [InlineData("Yes")]
        [InlineData("YES")]
        [InlineData("Y")]
        [InlineData("y")]
        public void string_Parse_Try_YesNo_true(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Try().YesNo();

            // assert
            Assert.True(parsed);
        }

        [Theory]
        [InlineData("no")]
        [InlineData("No")]
        [InlineData("NO")]
        [InlineData("N")]
        [InlineData("n")]
        public void string_Parse_Try_YesNo_false(string data)
        {
            // arrange            

            // act
            var parsed = data.Parse().Try().YesNo();

            // assert
            Assert.False(parsed);
        }

        [Fact]
        public void string_Parse_Try_YesNo_ok_on_null()
        {
            // arrange            
            string data = null;

            // act
            var parsed = data.Parse().Try().YesNo();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_YesNo_ok_on_empty()
        {
            // arrange            
            string data = string.Empty;

            // act
            var parsed = data.Parse().Try().YesNo();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void string_Parse_Try_YesNo_ok_on_text()
        {
            // arrange            
            string data = "hello world";

            // act
            var parsed = data.Parse().Try().YesNo();

            // assert
            Assert.Null(parsed);
        }
    }
}
