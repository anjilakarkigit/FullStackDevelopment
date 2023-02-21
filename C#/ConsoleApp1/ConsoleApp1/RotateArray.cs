using System;
namespace ConsoleApp1
{
	public class RotateArray
	{
		public RotateArray()
		{
		}

		public void Rotate()
		{
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int k = int.Parse(Console.ReadLine());

            int n = arr.Length;
            int[] sumArr = new int[n];

            // Rotate the array and calculate the sum for each rotation
            for (int r = 1; r <= k; r++)
            {
                int[] rotated = new int[n];
                for (int i = 0; i < n; i++)
                {
                    rotated[(i + r) % n] = arr[i];
                    sumArr[(i + r) % n] += arr[i];
                }
                arr = rotated;
            }

            // Print the resulting sum array
            Console.WriteLine(string.Join(" ", sumArr));
        }
	}
}

