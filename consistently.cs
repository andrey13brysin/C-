using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class consistently
	{
		static void Main(string[] args)
		{
			//так как требуется вывести последовательность состоящюю из чисел которые на каждой итерации увеличиваются на одно и тоже число.
			//разумно будет использовать цикл for с шагом 7
			int maxNumber = 0;
			int startNumber = 0;
			int step = 7;

			Console.WriteLine("enter max number");
			maxNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter start number");
			startNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("--------------");

			for (int i = startNumber; i <= maxNumber; i += step)
			{
				Console.WriteLine($"{i} ");
			}

			Console.ReadKey();
		}
	}
}
