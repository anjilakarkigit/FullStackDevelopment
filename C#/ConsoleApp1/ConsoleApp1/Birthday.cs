using System;
namespace ConsoleApp1
{
	public class Birthday
	{
		public Birthday()
		{
		}
		
        public void CalculateDays()
        {
            // Enter the birth date in format: year, month, day
            DateTime birthDate = new DateTime(1990, 3, 15);

            // Calculate age in days
            TimeSpan age = DateTime.Today - birthDate;
            int ageInDays = (int)age.TotalDays;

            Console.WriteLine("You are {0} days old.", ageInDays);

            // Calculate next anniversary date
            int daysToNextAnniversary = 10000 - (ageInDays % 10000);
            DateTime nextAnniversaryDate = DateTime.Today.AddDays(daysToNextAnniversary);

            Console.WriteLine("Your next 10,000 day anniversary is on {0:d}.", nextAnniversaryDate);
        }
    }

}

