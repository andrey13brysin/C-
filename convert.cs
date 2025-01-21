using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class convert
	{
		static void Main(string[] args)
		{
			const string ConvertFranksToDollarsCommand = "1";
			const string ConvertDollarsToFranksCommand = "2";
			const string ConvertRublesToDollarsCommand = "3";
			const string ConvertDollarsToRublesCommand = "4";
			const string ConvertFranksToRublesCommand = "5";
			const string ConvertRublesToFranksCommand = "6";
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

			string delim = "-------------";

			bool isRunning = false;

			while (isRunning == false)
			{
				Console.WriteLine("your balance:");
				Console.WriteLine(delim);
				Console.WriteLine($"franks: {frankBalance}");
				Console.WriteLine($"rubles: {rubleBalance}");
				Console.WriteLine($"dollars: {dollarBalance}");
				Console.WriteLine(delim);

				Console.WriteLine("Commands:");
				Console.WriteLine(delim);
				Console.WriteLine(ConvertFranksToDollarsCommand);
				Console.WriteLine(ConvertDollarsToFranksCommand);
				Console.WriteLine(ConvertRublesToDollarsCommand);
				Console.WriteLine(ConvertDollarsToRublesCommand);
				Console.WriteLine(ConvertFranksToRublesCommand);
				Console.WriteLine(ConvertRublesToFranksCommand);
				Console.WriteLine(ExitCommand);
				Console.WriteLine(delim);

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
