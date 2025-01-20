using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class convert
	{
		static void Main(string[] args)
		{
			const string ConvertFranksToDollarsCommand = "convert franks to dollars";
			const string ConvertDollarsToFranksCommand = "convert dollars to franks";
			const string ConvertRublesToDollarsCommand = "convert rubles to dollars";
			const string ConvertDollarsToRublesCommand = "convert dollars to rubles";
			const string ConvertFranksToRublesCommand = "convert franks to rubles";
			const string ConvertRublesToFranksCommand = "convert rubles to franks";
			const string ExitCommand = "exit";

			float frankToDollarRate = 1.09f;
			float dollarToFrankRate = 0.9f;
			float rubleToDollarRate = 0.009f;
			float dollarToRubleRate = 102.41f;
			float frankToRubleRate = 112.39f;
			float rubleToFrankRate = 0.0088f;

			float frankBalance = 1000.0f;
			float rubleBalance = 1000.0f;
			float dollarBalance = 1000.0f;

			bool isRunning = false;

			while (isRunning == false)
			{
				Console.WriteLine("your balance:");
				Console.WriteLine("-------------");
				Console.WriteLine($"franks: {frankBalance}");
				Console.WriteLine($"rubles: {rubleBalance}");
				Console.WriteLine($"dollars: {dollarBalance}");
				Console.WriteLine("-------------");

				Console.WriteLine("Commands:");
				Console.WriteLine("-------------");
				Console.WriteLine(ConvertFranksToDollarsCommand);
				Console.WriteLine(ConvertDollarsToFranksCommand);
				Console.WriteLine(ConvertRublesToDollarsCommand);
				Console.WriteLine(ConvertDollarsToRublesCommand);
				Console.WriteLine(ConvertFranksToRublesCommand);
				Console.WriteLine(ConvertRublesToFranksCommand);
				Console.WriteLine(ExitCommand);
				Console.WriteLine("-------------");

				Console.WriteLine("Enter command");
				string command = Console.ReadLine().ToLower();

				float countСurrencyToConvert = 0.0f;

				switch (command)
				{
					case ConvertFranksToDollarsCommand:
						Console.WriteLine("how many currency to exchange?");
						countСurrencyToConvert = Convert.ToSingle(Console.ReadLine());
						if(frankBalance - countСurrencyToConvert >= 0)
						{
							frankBalance -= countСurrencyToConvert;
							dollarBalance += countСurrencyToConvert * frankToDollarRate;
						}
						else
						{
							Console.WriteLine("insufficient funds");
						}
						break;
					case ConvertDollarsToFranksCommand:
						Console.WriteLine("how many Сurrency to exchange?");
						countСurrencyToConvert = Convert.ToSingle(Console.ReadLine());
						if (dollarBalance - countСurrencyToConvert >= 0)
						{
							dollarBalance -= countСurrencyToConvert;
							frankBalance += countСurrencyToConvert * dollarToFrankRate;
						}
						else
						{
							Console.WriteLine("insufficient funds");
						}
						break;
					case ConvertRublesToDollarsCommand:
						Console.WriteLine("how many Сurrencyto exchange?");
						countСurrencyToConvert = Convert.ToSingle(Console.ReadLine());
						if (rubleBalance - countСurrencyToConvert >= 0)
						{
							rubleBalance -= countСurrencyToConvert;
							dollarBalance += countСurrencyToConvert * rubleToDollarRate;
						}
						else
						{
							Console.WriteLine("insufficient funds");
						}
						break;
					case ConvertDollarsToRublesCommand:
						Console.WriteLine("how many Сurrencyto exchange?");
						countСurrencyToConvert = Convert.ToSingle(Console.ReadLine());
						if (rubleBalance - countСurrencyToConvert >= 0)
						{
							dollarBalance -= countСurrencyToConvert;
							rubleBalance += countСurrencyToConvert * dollarToRubleRate;
						}
						else
						{
							Console.WriteLine("insufficient funds");
						}
						break;
					case ConvertFranksToRublesCommand:
						Console.WriteLine("how many Сurrencyto exchange?");
						countСurrencyToConvert = Convert.ToSingle(Console.ReadLine());
						if (frankBalance - countСurrencyToConvert >= 0)
						{
							frankBalance -= countСurrencyToConvert;
							rubleBalance += countСurrencyToConvert * frankToRubleRate;
						}
						else
						{
							Console.WriteLine("insufficient funds");
						}
						break;
					case ConvertRublesToFranksCommand:
						Console.WriteLine("how many Сurrencyto exchange?");
						countСurrencyToConvert = Convert.ToSingle(Console.ReadLine());
						if (rubleBalance - countСurrencyToConvert >= 0)
						{
							rubleBalance -= countСurrencyToConvert;
							frankBalance += countСurrencyToConvert * rubleToFrankRate;
						}
						else
						{
							Console.WriteLine("insufficient funds");
						}
						break;
					case ExitCommand:
						isRunning = true;
						break;
				}

				Console.WriteLine("Enter key to continue");
				Console.ReadKey();

				Console.Clear();
			}
		}
	}
}
