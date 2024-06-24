using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("banana", false)]
        [InlineData("madam", true)]
        [InlineData("Taco cat", true)]
        public void IsAPalindromeTest(string input, bool expected)
        {
            //Assert
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPalindrome(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
