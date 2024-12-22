using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CS_JUN_1
{
	internal class Interpolation
	{
		public static string Rep_Q(string[] term)
		{
			bool isRepid = true;

			string newEnter = "";

			while(isRepid)
			{
				newEnter = Console.ReadLine();

				for (int i = 0; i < term.Length; i++)
				{
					if(newEnter.ToLower() == term[i].ToLower())
					{
						isRepid = false;
					}
				}

				Console.WriteLine("Некоректный ответ, попробуйте еще раз");
			}

			return newEnter;

		}
		static void Main(string[] args)
		{
			string[] enters = new string[10];
			string[] variants = { "НЕТ", "ДА" };

			Console.WriteLine("Здравствуйте, вы человек? ДА/НЕТ");
			enters[0] = Rep_Q(variants);
			if (enters[0].ToLower() == "да")
			{
				
			}
			else
			{
				Console.WriteLine("А кто вы???? (-_-)");
				Console.ReadLine();
				Console.WriteLine("Соболезную, досвидания");
				Console.ReadLine();
				return;
			}


			Console.WriteLine("вы мужчина? ДА/НЕТ");
			enters[1] = Rep_Q(variants);
			if (enters[0].ToLower() == "да")
			{
				Random r = new Random();
				if((r.NextDouble() % 1.0) > 0.95)
				{
					if(enters[0].ToLower() == "да")
					{
						Console.WriteLine("проигрывал?");
						Console.WriteLine("ДА");
						Console.WriteLine("круто я тоже");
						Console.ReadKey();
					}
					else
					{
						Console.Clear();
						Console.WriteLine("тут и так понятно");
						Console.ReadKey();
					}
					return;
				}
			}

			Console.WriteLine("как тебя зовут?");
			enters[2] = Console.ReadLine();

			Console.WriteLine("вы успешный програмист и делаете игры ?");

			enters[3] = Rep_Q(variants);

			if (enters[3].ToLower() == "да")
			{
				Console.WriteLine("тогда предлагаю вам не тратить время, и купить проверку этой программы (ENTER)");
				enters[4] = Console.ReadLine();
				if (enters[4] == "\n")
				{
					Console.WriteLine("удачи " + enters[2]);
					return;
				}
			}
			else
			{
				string[] tt = { "gfhjkm" };
				Console.WriteLine("ладно тогда введите пароль для продолжения");
				Rep_Q(tt);
				Console.WriteLine("вы человек " + (enters[1] == "ДА" ? "Муржского" : "Женского") + " пола, по имени " + enters[2] + " и вы не успешный програмист, в чем я вам сильно сочувствую*");
				Console.ReadLine();
			}
		}
	}
}
