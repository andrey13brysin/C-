using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class Img
	{
		static void Main(string[] args)
		{
            int maxImageInRow = 3;
            System.Console.WriteLine($"Max image in row: {maxImageInRow}");

		    int imageCount = 52;
            System.Console.WriteLine($"Image Count: {imageCount}");
		    int excessImage = imageCount % maxImageInRow;;

			Console.WriteLine($"remains: {excessImage}");
            Console.ReadKey();
		}
	}
}
