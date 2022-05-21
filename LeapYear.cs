using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class LeapYear
    {
        public static void TheLeapYear()
        {
            Console.WriteLine("Enter year");

            int year = int.Parse(Console.ReadLine()); 
            //The int.Parse() method is used to convert a string to an integer value


            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                //checking for leap year or not
            {
                Console.WriteLine(" It is a leap year  ", year );
            }
            else
            {
                Console.WriteLine(" It is not leap year ", year);
            }
        }
    }
}
