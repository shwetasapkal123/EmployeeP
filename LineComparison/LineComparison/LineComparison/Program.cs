using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC1 length=new UC1();
            length.CalLength(2, 4, 6, 8);

            UC2.CompareLine();
            UC3.Compare();
            Console.ReadLine();
        }
    }
}
