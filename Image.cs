using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class Img
	{
		static void Main(string[] args)
		{
            int MaxImageInRow = 3;
            System.Console.WriteLine($"Max image in row: {MaxImageInRow}");

		    int imageCount = 52;
            System.Console.WriteLine($"Max image in row: {imageCount}");
		    int excess;
			excess = imageCount % MaxImageInRow;
			Console.WriteLine($"remains: {excess}");
            Console.ReadKey();
		}
	}
}
