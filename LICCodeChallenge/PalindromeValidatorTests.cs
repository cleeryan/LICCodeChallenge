using NUnit.Framework;

namespace LICCodeChallenge
{
	[TestFixture]
	public class PalindromeValidatorTests
	{
		
		[TestCase("caaaaaaaab")]
		[TestCase("owefhijpfwai")]
		public void WhenNotAPalindromeOrAnagramOfPalindrome_Check_ReturnsFalse(string input)
		{
			//Arrange
			var palindromValidator = new PalindromeValidator();

			//Act
			var result = palindromValidator.IsPalindromeOrAnagramOfPalindrome(input);

			//Assert
			Assert.IsFalse(result);
		}

		[TestCase("anna")]
		[TestCase("aaaaaaaa")]
		[TestCase("aaaaaaaab")]
		[TestCase("igdedgide")]
		[TestCase("donotbobtonod")]
		public void WhenIsPalindromeOrAnagramOfPalindrome_Check_ReturnsTrue(string input)
		{
			//Arrange
			var palindromValidator = new PalindromeValidator();

			//Act
			var result = palindromValidator.IsPalindromeOrAnagramOfPalindrome(input);

			//Assert
			Assert.IsTrue(result);
		}

		[TestCase("anna")]
		[TestCase("aaaaaaaa")]
		[TestCase("donotbobtonod")]
		public void WhenIsPalindrome_IsPalindrome_ReturnsTure(string input)
		{
			//Arrange
			var palindromValidator = new PalindromeValidator();

			//Act
			var result = palindromValidator.IsPalindrome(input);

			//Assert
			Assert.IsTrue(result);
		}

		[TestCase("aaaaaaaab")]
		[TestCase("igdedgide")]
		[TestCase("caaaaaaaab")]
		[TestCase("owefhijpfwai")]
		public void WhenIsAnagramOfPalindromeorNeither_IsPalindrome_ReturnsTure(string input)
		{
			//Arrange
			var palindromValidator = new PalindromeValidator();

			//Act
			var result = palindromValidator.IsPalindrome(input);

			//Assert
			Assert.IsFalse(result);
		}

	}
}