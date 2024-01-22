using System;

namespace EWP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Management System");
            Random rnd = new Random();

            int totalDays = 20;  
            int totalWages = 0;

            for (int day = 1; day <= totalDays; day++)
            {
                int workType = rnd.Next(0, 2);  

                switch (workType)
                {
                    case 0:
                        Console.WriteLine($"Day {day}: Full-time");
                        totalWages += CalculateWages(20, 8);
                        break;
                    case 1:
                        Console.WriteLine($"Day {day}: Part-time");
                        totalWages += CalculateWages(20, 4);
                        break;
                    default:
                        Console.WriteLine($"Day {day}: Invalid work type");
                        break;
                }
            }

            Console.WriteLine($"Total wages for the month: {totalWages}");

            Console.ReadLine();
        }

        static int CalculateWages(int wagePerHour, int hoursWorked)
        {
            return wagePerHour * hoursWorked;
        }
    }
}
