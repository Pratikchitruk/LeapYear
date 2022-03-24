using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearDemo
{
    public class LeapYear
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("enter year :");
            
            int year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) Console.WriteLine("{0} is a leap year.", year);
            else Console.WriteLine("{0} is not leap year");
            Console.ReadLine();
        }
    }
}
