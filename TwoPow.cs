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
			int number = 0;
			int TwoInPow = 2;

			Random rand = new Random();
			number = rand.Next(0, 101);

			while(TwoInPow < number)
			{
				TwoInPow *= 2;
				pow++;
			}

			Console.WriteLine($"Number: {number}");
			Console.WriteLine($"Pow: {pow}");
			Console.WriteLine($"Two in pow: {TwoInPow}");
		}
	}
}
