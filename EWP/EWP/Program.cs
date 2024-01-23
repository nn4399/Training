using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int no_of_days = 0, no_of_hours = 0;
            while (no_of_days < 20 && no_of_hours <100)
            {
                int value = rnd.Next(3);
                no_of_hours += value * 4;
                no_of_days++;
                Console.WriteLine($"value : {value}  Hours : {no_of_hours}   Days : {no_of_days}");
            }
            int total_wages = no_of_hours * 20;
            Console.WriteLine($"Wages : {total_wages}");
            Console.ReadLine();
        }
    }
}