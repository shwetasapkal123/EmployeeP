using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenodd
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to find it is even or odd");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("{0} is even number", n);
            else
                Console.WriteLine("{0} is odd number", n);
            Console.ReadLine();
        }
    }
}
