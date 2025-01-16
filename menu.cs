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

			bool isExit = false;
			Random random = new Random();

			while(!isExit) 
			{
				Console.WriteLine("Commands:");
				Console.WriteLine("-------------");
				Console.WriteLine("output first");
				Console.WriteLine("output second");
				Console.WriteLine("random");
				Console.WriteLine("Clear");
				Console.WriteLine("exit");
				Console.WriteLine("-------------");

				Console.WriteLine("Enter command");
				string command = Console.ReadLine().ToLower();

				switch (command)
				{
					case OutputStringFirstCommand:
						{
							Console.WriteLine("pricorm\n");
						} break;
					case OutputStringSecondCommand:
						{
							Console.WriteLine("dyrey\n");
						}break;
					case DisplayRandomNumberCommand:
						{
							int randomNumber = random.Next();
							Console.WriteLine($"random number: {randomNumber}\n");
						}break;
					case ClearConsoleCommand:
						{
							Console.Clear();
						}break;
					case ExitCommand:
						{
							isExit = true;
						}break;
				}			
			}
		}
	}
}
