using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    { 


        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("radar", true)]
        [InlineData("car", false)]
        [InlineData("Radar", true)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            var actual = test.isAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
