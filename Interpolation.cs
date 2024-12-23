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
			System.Console.Write("как вас зовут? ");
			string name = System.Console.ReadLine();

			System.Console.Write("где вы работаете? ");
			string job = System.Console.ReadLine();

			System.Console.Write("вы много знаете? ");
			string know = System.Console.ReadLine();

			System.Console.Write("как вы спите? ");
			string sleep = System.Console.ReadLine();

			System.Console.WriteLine($"Вас зовут {name}, вы работаете {job}, вы {know} знаете и {sleep} спите");

			System.Сonsole.ReadKey();
		}
	}
}
