using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Factors
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Prime Factorisation");  // there should not be remainder
            int a,
                b;
            Console.WriteLine(" enter number: ");// user input

            a = int.Parse(Console.ReadLine());


            for (b = 2; a > 1; b++) //check divisible by 2 or not

                if (a % b == 0) //remainder must be zero
                {
                    int x = 0;

                    while (a % b == 0) //remainder must be zero
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times!");
                }

        }
    }
}
