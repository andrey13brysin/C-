using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class bober
	{
		static void Main(string[] args)
		{
			string tryingPassword = "";
			string password = "qwer";
			int currentTrying = 0;
			int allowedTrying = 3;
			bool isRun = true;

			while(isRun != false)
			{
				Console.WriteLine("Enter password");
				tryingPassword = Console.ReadLine();

				currentTrying++;

				if (password == tryingPassword)
				{
					Console.WriteLine("bober");
					isRun = false;
				}
				else if (currentTrying >= allowedTrying)
				{
					Console.WriteLine("exceeded the number of trying");
					isRun = false;
				}
			}
		}
	}
}
