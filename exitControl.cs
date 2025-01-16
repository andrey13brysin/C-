using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class exitControl
	{
		static void Main(string[] args)
		{
			string requiredValue = "exit";
			bool isExit = false;
			string enterValue = "";

			while (enterValue != requiredValue)
			{
				Console.WriteLine($"for exit enter \"{requiredValue}\" ");
				enterValue = Console.ReadLine();
			}
		}
	}
}
