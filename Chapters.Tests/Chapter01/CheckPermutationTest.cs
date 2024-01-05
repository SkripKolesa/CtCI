using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class CheckPermutationTest
    {
        [Theory]
        [InlineData("","")]
        [InlineData("a","a")]
        [InlineData("123","321")]
        [InlineData("Hello, World!","World, Hello!")]
        [InlineData("aaassdf", "asasafd")]
        public void PermutationCheck(string a, string b)
        {
            Assert.True(Solutions.IsPermutationOf(a, b));
        }
        
        [Theory]
        [InlineData("","a")]
        [InlineData("ab","a")]
        [InlineData("123","120")]
        [InlineData("Hello, World!","World, hello!")]
        [InlineData("aaassdf", "asa safd")]
        public void NonPermutationCheck(string a, string b)
        {
            Assert.False(Solutions.IsPermutationOf(a,b));
        }
    }
}