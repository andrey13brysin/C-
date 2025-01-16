using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class randomNumber
	{
		static void Main(string[] args)
		{
			int randomNumber = 0;
			int numberSum = 0;

			Random random = new Random();
			randomNumber = random.Next(0, 100);

			Console.WriteLine($"Random number: {randomNumber}");

			for (int i = 0; i <= randomNumber; i++)
			{
				if(i % 3 == 0 || i % 5 == 0)
				{
					numberSum += i;
				}
			}

			Console.WriteLine($"Numbers sum: {numberSum}");
			Console.ReadKey();
		}
	}
}
