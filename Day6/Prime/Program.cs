using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, counter = 0;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            for(i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    counter++;
                    break;
                }
            }
            if(counter==0&&num!=1)
            {
                Console.WriteLine("{0} is a prime number",num );
            }
            else
            {
                Console.WriteLine("{0} is not prime number");
            }
            Console.ReadLine();
        }
    }
}
