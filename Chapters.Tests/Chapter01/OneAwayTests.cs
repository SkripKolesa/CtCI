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
        [InlineData("pale", "pake")]
        public void IsOneAway(string a, string b)
        {
            Assert.True(a.IsOneOrZeroAwayFrom(b));
            Assert.True(b.IsOneOrZeroAwayFrom(a));
        }

        [Theory]
        [InlineData("pale", "bald")]
        [InlineData("a", "abc")]
        [InlineData("pale", "bake")]
        [InlineData("pale", "")]
        [InlineData("", "ab")]
        [InlineData("paka", "pa")]
        public void NotIsOneAway(string a, string b)
        {
            Assert.False(a.IsOneOrZeroAwayFrom(b));
            Assert.False(b.IsOneOrZeroAwayFrom(a));
        }
    }
}