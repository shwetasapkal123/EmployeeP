using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i=1, sum=0;
            int min, max;
            Console.WriteLine("Give starting range or number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give ending range or number");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect number within range is");

            for(n=min;n<=max;n++)
            {
                while(i<n)
                {
                    if(n%i==0)
                    {
                        sum +=  i;
                        i++;
                    }
                    if(sum==n)
                    {
                        Console.WriteLine("{0}",n);
                    }
                }

            }
        }
    }
}
