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
            int firstDivider = 3;
            int secondDivider = 5;
            int maxNumber = 100;
            int minNumber = 0;  

			Random random = new Random();
			randomNumber = random.Next(minNumber, maxNumber);

			Console.WriteLine($"Random number: {randomNumber}");

			for (int i = 0; i <= randomNumber; i++)
			{
				if(i % firstDivider == 0 || i % secondDivider == 0)
				{
					numberSum += i;
				}
			}

			Console.WriteLine($"Numbers sum: {numberSum}");
			Console.ReadKey();
		}
	}
}
