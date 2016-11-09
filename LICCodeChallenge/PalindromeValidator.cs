using System.Linq;

namespace LICCodeChallenge
{
	public class PalindromeValidator 
	{
		/// <summary>
		/// Checks whether a string is an anagram of a palindrome (or a palindrome)
		/// </summary>
		/// <param name="input">The string to check, assumes no whitespace ond all lowercase alpha characters</param>
		/// <returns>True if it is either an anagram of a palindrome or a palindrome</returns>
		public bool IsPalindromeOrAnagramOfPalindrome(string input)
		{
			var groupedResult = input.GroupBy(i => i).ToList();
			var letterCount = groupedResult.Count();
			var evenCountOfLetters = groupedResult.Count(g => g.Count() % 2 == 0);

			return letterCount == evenCountOfLetters || letterCount - 1 == evenCountOfLetters;
		}


		/// <summary>
		/// Determines whether a string is a palindrome
		/// </summary>
		/// <param name="input">The string to check, assumes no whitespace ond all lowercase alpha characters</param>
		/// <returns>True if it a palindrome</returns>
		public bool IsPalindrome(string input)
		{
			var lowerIndex = 0;
			var upperIndex = input.Length - 1;

			while (lowerIndex < upperIndex)
			{
				if (input[lowerIndex] != input[upperIndex])
				{
					return false;
				}
				lowerIndex++;
				upperIndex--;
			}

			return true;
		}
	}
	
}