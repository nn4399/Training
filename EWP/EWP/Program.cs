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


            Console.ReadLine();

        }
    }
}
