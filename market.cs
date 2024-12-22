using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class market
	{
        static void Main(string[] args)
		{
			int cost = 100;
			int gold = 0;
			int crystals = 0;
			int crystalsBuyCount = 0;

            Console.Write("enter the amount of gold: ");
			gold = Convert.ToInt32(Console.ReadLine());

			Console.Write("How many crystals do you want to buy? ");
			crystalsBuyCount = Convert.ToInt32(Console.ReadLine());

			gold -= cost * crystalsBuyCount;
			crystals += crystalsBuyCount;

			Console.WriteLine($"Your crystals: {crystals}");
			Console.WriteLine($"Your gold: {gold}");

			Console.ReadKey();
		}
	}
}
