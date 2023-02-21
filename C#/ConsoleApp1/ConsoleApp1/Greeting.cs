using System;
namespace ConsoleApp1
{
	public class Grreeting
	{
		public Grreeting()
		{
		}

		public void Greet()
		{
            // Get the current time
            DateTime now = DateTime.Now;

            // Extract the hour from the current time
            int hour = now.Hour;

            // Greet the user based on the time of day
            if (hour >= 0 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (hour >= 18 && hour < 22)
            {
                Console.WriteLine("Good Evening");
            }
            if (hour >= 22 || hour < 0)
            {
                Console.WriteLine("Good Night");
            }
        }
	}
}

