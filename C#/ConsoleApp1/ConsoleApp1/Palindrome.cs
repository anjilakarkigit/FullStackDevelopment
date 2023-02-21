using System;
namespace ConsoleApp1
{
	public class Palindrome
	{
		public void FindPalindrome()
		{
            string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

            // Define the separators between words
            char[] separators = new char[] { ' ', ',', '.', ':', ';', '?', '!' };

            // Split the text into words using the separators
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Define a list to store the palindromes
            List<string> palindromes = new List<string>();

            // Iterate over the words and check if they are palindromes
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            // Remove duplicate palindromes and sort the list
            palindromes = palindromes.Distinct().OrderBy(s => s).ToList();

            // Print the palindromes on a single line, separated by comma and space
            Console.WriteLine(string.Join(", ", palindromes));
        }

        // Helper function to check if a string is a palindrome
        static bool IsPalindrome(string s)
        {
            // Convert the string to lowercase and remove all non-letter characters
            s = new string(s.ToLower().Where(char.IsLetter).ToArray());
            // Compare the original string with its reverse
            return s.SequenceEqual(s.Reverse());
        }
	}
}

