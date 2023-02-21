using System;
namespace ConsoleApp1
{
	public class FrequentNumber
	{
		public void FindFrequentNumber()
		{
            int[] numbers = { 1, 3, 4, 2, 2, 4, 1, 2, 2, 4, 9 };
            int n = numbers.Length;

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = numbers[i];
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            int maxFrequency = frequency.Values.Max();
            int mostFrequentNumber = frequency.First(x => x.Value == maxFrequency).Key;

            Console.WriteLine("Most frequent number: " + mostFrequentNumber);
        }
	}
}

