using System;
namespace ConsoleApp1
{
	public class CenturyConversion
	{

        public static void ConvertCentury(ref int centuries)
        {
            long years = centuries * 100;
            long days = years * 365 + years / 4 - years / 100 + years / 400;
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            long nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries is equal to:", centuries);
            Console.WriteLine("{0:N0} years", years);
            Console.WriteLine("{0:N0} days", days);
            Console.WriteLine("{0:N0} hours", hours);
            Console.WriteLine("{0:N0} minutes", minutes);
            Console.WriteLine("{0:N0} seconds", seconds);
            Console.WriteLine("{0:N0} milliseconds", milliseconds);
            Console.WriteLine("{0:N0} microseconds", microseconds);
            Console.WriteLine("{0:N0} nanoseconds", nanoseconds);
        }

        //public static void Main(string[] args)
        //{
        //    int century;

        //    Console.Write("Enter a number of centuries: ");
        //    century = Convert.ToInt32(Console.ReadLine());
        //    ConvertCentury(ref century);
        //}
    }
	
}

