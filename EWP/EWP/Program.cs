using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Management System");
            Random rnd = new Random();
            int attendence = rnd.Next(0,1);
            if (attendence == 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
            int wage_per_hour = 20;
            int full_day = 8;
            int uc2 = wage_per_hour * full_day;
            Console.WriteLine(uc2);
            int part_time = 4;
            int uc3 = wage_per_hour * part_time;
            Console.WriteLine(uc3);
            Console.ReadLine();


        }
    }
}
