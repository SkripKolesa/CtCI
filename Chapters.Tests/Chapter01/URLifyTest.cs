using System;
using System.Linq;
using Chapters.Chapter01;
using Xunit;

namespace Chapters.Tests.Chapter01
{
    public class URLifyTest
    {
        [Theory]
        [InlineData("Hi, Mr. Smith!")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("  ")]
        [InlineData(" Lorem ipsum dripsum lalala... That's it. Done. ")]
        [InlineData("A")]
        [InlineData("A ")]
        [InlineData(" A")]
        public void Test(string input)
        {
            var arr = input.ToCharArray();
            var chInput = new char[arr.Length + arr.Count(c => c == ' ') * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                chInput[i] = arr[i];
            }

            var actual = new string(URLify.ReplaceSpaces(chInput, arr.Length));
            Assert.Equal(input.Replace(" ", "%20"), actual);
        }
    }
}