using System;
namespace ConsoleApp1
{
	public class RandomNumber
	{
		public RandomNumber()
		{
		}

		public void calculation()
		{
            int guessedNum = 5;
            int correctNumber = new Random().Next(3) + 1;

            

			while(guessedNum != correctNumber)
			{
                Console.Write("Guess the number: ");
                guessedNum = int.Parse(Console.ReadLine());

                if (guessedNum< 1)
				{
					Console.WriteLine("less than 1");
				}
                if (guessedNum > 3)
                {
                    Console.WriteLine("more than 3");
                }
            }

			Console.WriteLine("You got it!");
            

        }

    }
}

