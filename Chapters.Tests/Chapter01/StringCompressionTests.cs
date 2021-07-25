using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class StringCompressionTests
    {
        [Theory]
        [InlineData("aabccccaaa", "a2bc5a3")]
        public void TestCompress(string str, string compressed)
        {
            Assert.Equal(str.Compress(), compressed);
        }
    }
}