﻿using System;
namespace ConsoleApp1
{
	public class FizzBuzz
	{
		public FizzBuzz()
		{

		}

		public void CountingGame()
		{
			for(int i =0; i<=100; i++)
			{
				if (i%3 == 0 && i%5 ==0)
				{
					Console.WriteLine("FizzBuzz");
				} else if(i%5 == 0)
				{
					Console.WriteLine("Buzz");
				}else if(i%3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}

