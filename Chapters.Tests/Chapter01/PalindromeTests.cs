using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("Tact Coa")]
        public void PalindromePermutationCanBePalindrome(string input)
        {
            Assert.True(input.CanBePalindrome());
        }

        [Theory]
        [InlineData("asdf")]
        public void NonPalindromePermutationIsNot(string input)
        {
            Assert.False(input.CanBePalindrome());
        }
    }
}