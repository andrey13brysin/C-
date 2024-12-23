using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CS_JUN_1
{
	internal class Interpolation
	{
		static void Main(string[] args)
		{
			Console.Write("как вас зовут? ");
			string name = Console.ReadLine();

			Console.Write("где вы работаете? ");
			string job = Console.ReadLine();

			Console.Write("вы много знаете? ");
			string know = Console.ReadLine();

			Console.Write("как вы спите? ");
			string sleep = Console.ReadLine();

			System.Console.WriteLine($"Вас зовут {name}, вы работаете {job}, вы {know} знаете и {sleep} спите");

			Сonsole.ReadKey();
		}
	}
}
