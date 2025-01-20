using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class multiples
	{
		static void Main(string[] args)
		{
			int beginNumberRange = 10;
			int endNumberRange = 25;
			int multiplesRangeBegin = 50;
			int multiplesRangeEnd = 150;
			int repidCount = 0;
			int number = 0;
			int multiplesCount = 0;

			Random random = new Random();
			number = random.Next(beginNumberRange, endNumberRange);
			Console.WriteLine($"number: {number}");

			for(int i = 0; i <= multiplesRangeEnd; i++)
			{
				if (repidCount == number)
				{
					if(i >= multiplesRangeBegin)
					{
						multiplesCount++;
					}
					repidCount = 0;
				}
				repidCount++;
			}

			Console.WriteLine($"multiplesCount: {multiplesCount}");
		}
	}
}
