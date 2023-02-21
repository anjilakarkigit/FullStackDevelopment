using System;
namespace ConsoleApp1
{
	public class LongestSequence
	{
		public LongestSequence()
		{
		}

		public void FindLongestSequence()
		{
            int[] arr = { 1, 1, 1, 2, 3, 3, 4, 4, 4, 4 };
            int n = arr.Length;

            int maxLength = 0;
            int maxStartIndex = 0;

            int currentLength = 1;
            int currentStartIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }
                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }

            Console.WriteLine("Longest sequence of equal elements:");
            for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
	}
}

