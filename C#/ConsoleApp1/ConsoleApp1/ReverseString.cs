using System;
namespace ConsoleApp1
{
	public class ReverseString
	{
		public void ReverseUsingArray()
		{
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            // Convert string to char array
            char[] charArray = str.ToCharArray();

            // Reverse the char array
            Array.Reverse(charArray);

            // Convert char array back to string and print
            Console.WriteLine(new string(charArray));
        }

        public void ReverseUsingLoop()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            // Print the characters of the string in reverse order
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();

        }

    }
}

