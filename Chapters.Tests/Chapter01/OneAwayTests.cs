using Chapters.Chapter01;
using Xunit;
namespace Chapters.Tests.Chapter01
{
    public class OneAwayTests
    {
        [Theory]
        [InlineData("pale", "ple")]
        [InlineData("", "")]
        [InlineData("", "a")]
        [InlineData("a", "")]
        [InlineData("a", "a")]
        [InlineData("a", "ab")]
        [InlineData("pale", "pale")]
        [InlineData("pales", "pale")]
        [InlineData("pale", "pales")]
        [InlineData("pale", "bale")]
        public void IsOneAway(string a, string b)
        {
            Assert.True(a.IsOneAwayFrom(b));
            Assert.True(b.IsOneAwayFrom(a));
        }

        [Theory]
        [InlineData("pale", "bald")]
        [InlineData("a", "abc")]
        [InlineData("pale", "bake")]
        [InlineData("pale", "")]
        public void NonPalindromePermutationIsNot(string a, string b)
        {
            Assert.False(a.IsOneAwayFrom(b));
            Assert.False(b.IsOneAwayFrom(a));
        }
        
    }
}