
using System;
namespace ConsoleApp1
{
	public class CopyArray
	{
		public CopyArray()
		{
		}

		public void Copy()
        { 
                int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // Create a new array with the same length as the original array
                int[] copiedArray = new int[originalArray.Length];

                // Copy elements from the original array to the copied array
                for (int i = 0; i < originalArray.Length; i++)
                {
                    copiedArray[i] = originalArray[i];
                }

                // Print the contents of both arrays
                Console.WriteLine("Original array:");
                foreach (int element in originalArray)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Copied array:");
                foreach (int element in copiedArray)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }

    }


