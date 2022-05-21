using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//friday 20/05/22

namespace HelloWorld
{
    public class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("please enter the value for number of flips");

            int Head=0; 
            int Tail=0;
            int HeadCount=0;
            int TailCount=0;

            double HeadPercentage;
            double TailPercentage;

            int FlipCoin = Convert.ToInt32(Console.ReadLine());

            if (FlipCoin>0)
                for(int i=0;i<FlipCoin;i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number==1)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                    Console.WriteLine(number);
                }
            Console.WriteLine("-----------------");

            HeadPercentage = HeadCount * 100 / FlipCoin;
            TailPercentage = TailCount * 100 / FlipCoin;
            Console.WriteLine("Head Percentage: "+HeadPercentage);
            Console.WriteLine("Tail Percentage: "+TailPercentage);
        }
    }
}
