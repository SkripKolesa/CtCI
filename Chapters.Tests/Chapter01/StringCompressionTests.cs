using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class StringCompressionTests
    {
        [Theory]
        [InlineData("aabcccccaaa", "a2bc5a3")]
        [InlineData("","")]
        [InlineData("a","a")]
        [InlineData("aa","a2")]
        [InlineData("pacavaaaaca","pacava4ca")]
        [InlineData("Aa","Aa")]
        [InlineData("BBBBBye","B5ye")]
        [InlineData("BBcBBB","B2cB3")]
        public void TestCompress(string str, string compressed)
        {
            Assert.Equal(compressed, str.Compress());
        }
    }
}