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
		    int imageCount = 52;
		    int excess;
			excess = imageCount % MaxImageInRow;
			Console.WriteLine(excess);
		}
	}
}
