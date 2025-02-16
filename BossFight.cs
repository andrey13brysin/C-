using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class BossFight
	{
		static void Main(string[] args)
		{
			const string UsualAttackCommand = "attack";
			const string FireBallAttackCommand = "fireball";	
			const string HealingCommand = "healing";
			const string BangCommand = "bang";

			const string DividerString = "---------------";

			int playerHealth;
			int playerDamage;
			int playerMana;
			int playerManaConsumption = 20;
			int playerHealingCount = 10;
			int playerHealingSize;

			int bossDamade;
			int bossHealth;
			int convertBossDamageToHealth = 10;

			int bazeFullResources = 100;

			bool isGameRunning = true;
			bool isFireBallLaunched = false;
			bool isSkippingMove = false;

			string currentCommand = "";

			Random random = new Random();

			bossDamade = random.Next(10, 25);
			bossHealth = (bazeFullResources / convertBossDamageToHealth) * bossDamade;

			playerHealth = bazeFullResources;
			playerDamage = random.Next(10, 20);
			playerHealingSize = random.Next(25, 51);

			playerMana = bazeFullResources;

			while(isGameRunning != false)
			{
				Console.WriteLine("Select action:");

				Console.WriteLine(DividerString);

				Console.WriteLine(UsualAttackCommand);
				Console.WriteLine(FireBallAttackCommand);
				Console.WriteLine(HealingCommand);

				if (isFireBallLaunched != false)
				{
					Console.WriteLine(BangCommand);
				}

				Console.WriteLine(DividerString);

				Console.WriteLine("\nPlayer status:");

				Console.WriteLine(DividerString);
				Console.WriteLine($"Damage: {playerDamage}");
				Console.WriteLine($"Health: {playerHealth}");
				Console.WriteLine($"Mana: {playerMana}");
				Console.WriteLine(DividerString);

				Console.WriteLine("\nBoss status:");

				Console.WriteLine(DividerString);
				Console.WriteLine($"Damage: {bossDamade}");
				Console.WriteLine($"Health: {bossHealth}");
				Console.WriteLine(DividerString);

				if (isSkippingMove == false)
				{
					Console.Write("Enter command: ");
					currentCommand = Console.ReadLine().ToLower();
					
					switch (currentCommand)
					{
						case UsualAttackCommand:
							bossHealth -= playerDamage;
							break;
						case FireBallAttackCommand:
							isFireBallLaunched = true; 
							break;
						case HealingCommand:
							playerHealth += playerHealingSize;

							if (playerHealth > 100)
							{
								playerHealth = 100;
							}

							if (playerHealth > 0)
							{
								playerHealingCount--;
							}
							else 
							{
								isSkippingMove = true;
							}

							break;
						case BangCommand:
							bossHealth -= 2 * playerDamage;

							isFireBallLaunched = false;
							break;
						default:
							isSkippingMove = true;
							break;
					}
				}
				else
				{
					isSkippingMove = false;
					Console.Write("you skipping move. Pres key to continue ");
					Console.ReadKey();
				}

				playerHealth -= bossDamade;

				if(playerHealth <= 0)
				{
					Console.Clear();

					Console.WriteLine($"{DividerString}");
					Console.WriteLine("you lose");
					Console.WriteLine($"{DividerString}");

					Console.ReadKey();

					isGameRunning = false;
				}
				else if(bossHealth <= 0)
				{
					Console.Clear();

					Console.WriteLine($"{DividerString}");
					Console.WriteLine("you Win");
					Console.WriteLine($"{DividerString}");

					Console.ReadKey();

					isGameRunning = false;
				}
				else if(playerHealth <= 0 && bossHealth <= 0)
                {
					Console.Clear();

					Console.WriteLine($"{DividerString}");
					Console.WriteLine("you frending win");
					Console.WriteLine($"{DividerString}");

					Console.ReadKey();

					isGameRunning = false;
				}

				Console.Clear();
			}
		}
	}
}
