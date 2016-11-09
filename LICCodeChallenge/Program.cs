using System;
using System.Text.RegularExpressions;


namespace LICCodeChallenge
{
	public class Program
	{
		private static bool _continueProgram = true;
		private static readonly Regex ValidInputRegex = new Regex("^[a-z]+$");

		private static void Main(string[] args)
		{
			var palindromeValidator =  new PalindromeValidator();
	
			while (_continueProgram)
			{
				var output = "Neither";
				Console.Write("Please enter a string: ");
				var input = Console.ReadLine();

				if (!InputIsOk(input))
				{
					Console.WriteLine("String must be all lowercase letters a-z with no spaces");
					continue;
				}
			
				var isPalindromeOrAnagramOfPalindrome = palindromeValidator.IsPalindromeOrAnagramOfPalindrome(input);
				
				if (isPalindromeOrAnagramOfPalindrome)
				{
					var isPalindrome = palindromeValidator.IsPalindrome(input);
					output = isPalindrome ? "Palindrome": "Anagram of Palindrome";
				}

				Console.WriteLine(output);
				Console.Write("Press y to continue or n to exit ... ");
				_continueProgram = Console.ReadLine() == "y";
			}
		}
		
		private static bool InputIsOk(string input)
		{
			return ValidInputRegex.IsMatch(input);
		}
	}

}
