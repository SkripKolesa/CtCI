using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class IsUniqueTest
    {
        [Theory]
        [InlineData("asdf")]
        [InlineData("")]
        [InlineData("qwertyuiop[]=-0123$&^")]
        [InlineData("1234567890")]
        [InlineData("a")]
        public void ReturnsTrueForAllUnique(string input)
        {
            Assert.True(input.HasOnlyUniqueChars());
        }

        [Theory]
        [InlineData("aa")]
        [InlineData("asdfthtrehtreherherhz")]
        [InlineData("                  ")]
        [InlineData("121")]
        public void ReturnsFalseForNotAllUnique(string input)
        {
            Assert.False(input.HasOnlyUniqueChars());
        }
    }
}