using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class ManageList
	{
		public void ModifyList()
		{
            List<string> items = new List<string>();

            while (true)
            {
                Console.WriteLine("Current list:");
                foreach (string item in items)
                {
                    Console.WriteLine("," + item);
                }

                Console.Write("Enter command (+ item, - item, or delete to clear): ");
                string command = Console.ReadLine().Trim();

                if (command.StartsWith("+"))
                {
                    string item = command.Substring(1).Trim();
                    items.Add(item);
                }
                else if (command.StartsWith("-"))
                {
                    string item = command.Substring(1).Trim();
                    items.Remove(item);
                }
                else if (command == "delete")
                {
                    items.Clear();                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }

            }
		}
	}
}

