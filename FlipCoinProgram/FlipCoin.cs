using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinProgram
{
    internal class FlipCoin
    {
        public int head = 0;
        public int tail = 0;
        public int percentagehead = 0;
        public int percentagetail = 0;

        public void Checkpercentage()
        {
            Console.WriteLine("Enter number of times you want to flip coin");
            int flip_num= Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for(int i = 0; i < flip_num; i++)
            {
                double checkflip = random.Next(0, 2);
                if(checkflip > 0.5)
                {
                    Console.WriteLine("Tail");
                    tail++;
                }
                else
                {
                    Console.WriteLine("Head");
                    head++;
                }
            }
            percentagehead = head *(100/flip_num);
            percentagetail = tail * (100/flip_num);
            Console.WriteLine("Percentage of head :" + percentagehead + "Percentage of tail:" + percentagetail);
            Console.ReadKey();
        }
    }
}
