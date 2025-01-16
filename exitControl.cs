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
			bool requiredValueIsEntered = false;

			while(!requiredValueIsEntered)
			{
				Console.WriteLine("for exit enter \"exit\" ");
				string enterValue = Console.ReadLine();

				if( enterValue == requiredValue )
				{
					requiredValueIsEntered = true;
				}
			}
		}
	}
}
