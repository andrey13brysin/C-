using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class menu
	{
		static void Main(string[] args)
		{
			const string OutputStringFirstCommand = "output first";
			const string OutputStringSecondCommand = "output second";
			const string DisplayRandomNumberCommand = "random";
			const string ClearConsoleCommand = "clear";
			const string ExitCommand = "exit";

			bool isRunning = false;
			Random random = new Random();

			while (isRunning == false)
			{
				Console.WriteLine("Commands:");
				Console.WriteLine("-------------");
				Console.WriteLine(OutputStringFirstCommand);
				Console.WriteLine(OutputStringSecondCommand);
				Console.WriteLine(DisplayRandomNumberCommand);
				Console.WriteLine(ClearConsoleCommand);
				Console.WriteLine(ExitCommand);
				Console.WriteLine("-------------");

				Console.WriteLine("Enter command");
				string command = Console.ReadLine().ToLower();

				switch (command)
				{
					case OutputStringFirstCommand: 
						Console.WriteLine("pricorm\n"); 
						break;
					case OutputStringSecondCommand: 
						Console.WriteLine("dyrey\n"); 
						break;
					case DisplayRandomNumberCommand:
						int randomNumber = random.Next();
						Console.WriteLine($"random number: {randomNumber}\n");
						break;
					case ClearConsoleCommand:
						Console.Clear();
						break;
					case ExitCommand:
						isRunning = true;
						break;
				}
			}
		}
	}
}
