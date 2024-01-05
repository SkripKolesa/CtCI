using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("Tact Coa")]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("aa")]
        [InlineData("aaa a")]
        [InlineData("shalash")]
        public void PalindromePermutationCanBePalindrome(string input)
        {
            Assert.True(Solutions.CanBePalindrome(input));
        }

        [Theory]
        [InlineData("asdf")]
        [InlineData("axaa")]
        [InlineData("ab")]
        [InlineData("shu shu shu")]
        public void NonPalindromePermutationIsNot(string input)
        {
            Assert.False(Solutions.CanBePalindrome(input));
        }
    }
}