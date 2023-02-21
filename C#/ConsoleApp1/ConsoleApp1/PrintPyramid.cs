using System;
namespace ConsoleApp1
{
	public class PrintPyramid
	{
		public PrintPyramid()
		{
		}

		public void Print()
		{
            Console.Write("Enter the number of rows: ");
            int numRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numRows; i++)
            {
                for (int j = 1; j <= numRows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
	}
}

