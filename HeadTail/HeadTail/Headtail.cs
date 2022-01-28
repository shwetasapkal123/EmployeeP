using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadTail
{
     class Headtail
    {
        static void Main(string[] args)
        {
            int heads = 0, tails = 0;
            Console.WriteLine("Enter how many times want to flip coin");
            int n=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i <= n; i++)
            {
                double randomInput = random.NextDouble();
                Console.WriteLine("random input" + randomInput);
                if(randomInput<=0.5)
                {
                    if(randomInput==0)
                    {
                        Console.WriteLine("Heads");
                        heads+=1;
                    }
                    else
                    {
                        Console.WriteLine("Tails");
                        tails += 1;
                    }
                }
            }
            Console.WriteLine("Total number of Heads:{0} and Tails{1}", heads, tails);
            Console.ReadLine();
        }
    }
}
