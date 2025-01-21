using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class TwoPow
	{
		static void Main(string[] args)
		{
			int pow = 1;
			int termPow = 2;
			int number = 0;
			int numberToPow = 2;
			int maxNumber = 101;
			Random random = new Random();
			number = random.Next(0, maxNumber);

			while(numberToPow <= number)
			{
				numberToPow *= termPow;
				pow++;
			}

			Console.WriteLine($"Number: {number}");
			Console.WriteLine($"Pow: {pow}");
			Console.WriteLine($"Number to pow: {numberToPow}");
		}
	}
}
