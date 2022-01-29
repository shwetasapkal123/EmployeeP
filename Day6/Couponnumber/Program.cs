using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couponnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
           int randomInput1 = random.Next();
            //int preNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
               int randomInput = random.Next(0, num);
                
                if (randomInput == randomInput1)
                    Console.WriteLine("Not new number");
                else
                    Console.WriteLine("new number");

            }
            Console.ReadLine();
            
        }
    }
}
