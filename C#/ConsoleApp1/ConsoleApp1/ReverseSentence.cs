using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class ReverseSentence
    {
        public void Reverse()
        {
            string sentence = "This is a test sentence, to check the program: C# is awesome!";

            // Define the separators between the words
            string separators = @".,:;=()&[]""'\?! ";

            // Split the sentence into words and separators
            string[] wordsAndSeparators = Regex.Split(sentence, "([" + separators + "])");

            // Reverse the words
            Array.Reverse(wordsAndSeparators);

            // Join the words and separators back into a sentence
            string reversedSentence = String.Join("", wordsAndSeparators);

            Console.WriteLine(reversedSentence);
        } 
	}
}

