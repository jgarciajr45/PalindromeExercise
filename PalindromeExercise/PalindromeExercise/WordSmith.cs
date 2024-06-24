using System;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{
		
        public bool IsAPalindrome(string input)
        {
            var newInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            var revInput = new string(newInput.Reverse().ToArray());
            return newInput == revInput;
        }

        
    }
}

