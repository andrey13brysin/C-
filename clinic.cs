using System;
using System.Collections.Generic;
using System.Text;

namespace CS_JUN_1
{
	internal class clinic
	{
        static void Main(string[] args)
		{
            int receptionTime = 10;
            int minutesInHour = 60;

            System.Console.Write("enter the number of people in the queue: ");
            int peopleInQueue = Convert.ToInt32(Console.ReadLine());

            int hoursToReception = (peopleInQueue * receptionTime) / hour;
            int minutesToReception = (peopleInQueue * receptionTime) % hour;

            System.Console.Write($"You have to stand in line for {hoursToReception} hours {minutesToReception} minutes ");
            System.Console.ReadKey();
		}
	}
}
