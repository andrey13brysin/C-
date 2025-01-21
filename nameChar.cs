using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class nameChar
	{
		static void Main(string[] args)
		{
			string userName = "";
			string nameInBorder = "";
			string border = "";
			char userChar;

			Console.Write("Enter your name: ");
			userName = Console.ReadLine();

			Console.Write("Enter char: ");
			userChar = Console.ReadLine()[0];

			nameInBorder = $"{userChar}{userName}{userChar}";

			for (int i = 0; i < nameInBorder.Length; i++)
			{
				border += userChar;
			}

			Console.WriteLine(border);
			Console.WriteLine(nameInBorder);
			Console.WriteLine(border);
		}
	}
}
