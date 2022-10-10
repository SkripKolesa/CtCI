using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class StringRotationTests
    {
        [Theory]
        [InlineData("","")]
        [InlineData("a","a")]
        [InlineData("123","231")]
        [InlineData("waterbottle","erbottlewat")]
        [InlineData("Hello", "lloHe")]
        public void RotationCheck(string a, string b)
        {
            Assert.True(StringRotation.IsRotation(a,b));
        }
        
        [Theory]
        [InlineData("","a")]
        [InlineData("ab","ab")]
        [InlineData("123","312")]
        [InlineData("waterbottle","rebottlewat")]
        [InlineData("Hello", "lolHe")]
        public void NonRotationCheck(string a, string b)
        {
            Assert.True(!StringRotation.IsRotation(a,b));
        }
    }
}