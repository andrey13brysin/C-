using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class nameChar
	{
		static void Main(string[] args)
		{
			string userName;
			char userChar;
			int nameLenght = 0;
			int i = 0;

			Console.Write("Enter your name: ");
			userName = Console.ReadLine();
			nameLenght = userName.Length;

			Console.Write("Enter char: ");
			userChar = Console.ReadLine()[0];

			for(i = 0; i < nameLenght + 2; i++)
			{
				Console.Write(userChar);
			}

			Console.WriteLine($"\n{userChar}{userName}{userChar}");

			for (i = 0; i < nameLenght + 2; i++)
			{
				Console.Write(userChar);
			}
		}
	}
}
