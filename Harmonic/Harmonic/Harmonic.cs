using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic
{
     class Harmonic
    {
        static public void SumofHarmonic(int n)
        {
            double i, s = 0.0;
            for (i = 1; i <= n; i++)
            {
                s = s + 1 / i;
                
                Console.WriteLine("Sum is:"+s);
            }
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Enter number for Harmonic Series");
            int n = Convert.ToInt32(Console.ReadLine());
            SumofHarmonic(n);
            
            Console.ReadLine();
        }
    }
}
