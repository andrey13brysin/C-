using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class repid
	{
		static void Main(string[] args)
		{
			int repitCount = 0;
			string message = "";

			Console.WriteLine("enter the number of repetitions");
			repitCount = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter message");
			message = Console.ReadLine();
			Console.WriteLine("-----------------");


			for (int i = 0; i < repitCount; i++)
			{
				Console.WriteLine(message);
			}

			Console.ReadKey();
		}
	}
}

