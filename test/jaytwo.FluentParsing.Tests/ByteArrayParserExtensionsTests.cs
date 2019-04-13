using System;
using System.Text;
using Xunit;

namespace jaytwo.FluentParsing.Tests
{
    public class ByteArrayParserExtensionsTests
    {
        private static readonly string TestString = "hello world";
        private static readonly byte[] TestValue = Encoding.UTF8.GetBytes(TestString);

        [Fact]
        public void bytes_Parse_UTF8()
        {
            // arrange            

            // act
            var parsed = TestValue.Parse().UTF8();

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_UTF8_throws_on_null()
        {
            // arrange            
            byte[] data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().UTF8());
        }

        [Fact]
        public void bytes_Parse_UTF8_ok_on_empty()
        {
            // arrange            
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().UTF8();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_UTF8()
        {
            // arrange            

            // act
            var parsed = TestValue.Parse().Nullable().UTF8();

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_UTF8_ok_on_null()
        {
            // arrange            
            byte[] data = null;

            // act
            var parsed = data.Parse().Nullable().UTF8();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_UTF8_ok_on_empty()
        {
            // arrange            
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Nullable().UTF8();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_UTF8()
        {
            // arrange            

            // act
            var parsed = TestValue.Parse().Try().UTF8();

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Try_UTF8_ok_on_null()
        {
            // arrange            
            byte[] data = null;

            // act
            var parsed = data.Parse().Try().UTF8();

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_UTF8_ok_on_empty()
        {
            // arrange            
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Try().UTF8();

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_String()
        {
            // arrange            

            // act
            var parsed = TestValue.Parse().String(Encoding.ASCII);

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_String_throws_on_null()
        {
            // arrange            
            byte[] data = null;

            // act & assert
            Assert.Throws<ArgumentNullException>(() => data.Parse().String(Encoding.ASCII));
        }

        [Fact]
        public void bytes_Parse_String_ok_on_empty()
        {
            // arrange            
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().String(Encoding.ASCII);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_String()
        {
            // arrange            

            // act
            var parsed = TestValue.Parse().Nullable().String(Encoding.ASCII);

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_String_ok_on_null()
        {
            // arrange            
            byte[] data = null;

            // act
            var parsed = data.Parse().Nullable().String(Encoding.ASCII);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Nullable_String_ok_on_empty()
        {
            // arrange            
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Nullable().String(Encoding.ASCII);

            // assert
            Assert.Empty(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_String()
        {
            // arrange            

            // act
            var parsed = TestValue.Parse().Try().String(Encoding.ASCII);

            // assert
            Assert.Equal(TestString, parsed);
        }

        [Fact]
        public void bytes_Parse_Try_String_ok_on_null()
        {
            // arrange            
            byte[] data = null;

            // act
            var parsed = data.Parse().Try().String(Encoding.ASCII);

            // assert
            Assert.Null(parsed);
        }

        [Fact]
        public void bytes_Parse_Try_String_ok_on_empty()
        {
            // arrange            
            byte[] data = new byte[] { };

            // act
            var parsed = data.Parse().Try().String(Encoding.ASCII);

            // assert
            Assert.Empty(parsed);
        }
    }
}
