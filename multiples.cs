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
			int endNumberRange = 26;

			int multiplesRangeBegin = 50;
			int multiplesRangeEnd = 150;

			int number = 0;
			int multiplesCount = 0;

			Random random = new Random();
			number = random.Next(beginNumberRange, endNumberRange);

			Console.WriteLine($"number: {number}");

			for (int i = 0; i <= multiplesRangeEnd; i += number)
			{
				if (i >= multiplesRangeBegin)
				{
					multiplesCount++;
				}
			}

			Console.WriteLine($"multiplesCount: {multiplesCount}");
		}
	}
}
