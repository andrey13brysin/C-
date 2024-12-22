using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class Replace
	{
		static string temporary;
		static string firstWeapon = "m416";
		static string secondWeapon = "akm";

		static void Main(string[] args)
		{
			//вывод изходных данных
			Console.WriteLine("Before:");
			Console.WriteLine($"first weapon: {firstWeapon}");
			Console.WriteLine($"second weapon: {secondWeapon}");

			//перестановка
			temporary = firstWeapon;
			firstWeapon = secondWeapon;
			secondWeapon = temporary;

			//вывод результата
			Console.WriteLine("\nAfter:");
			Console.WriteLine($"first weapon: {firstWeapon}");
			Console.WriteLine($"second weapon: {secondWeapon}");

		}

	}
}