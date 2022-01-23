using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
     class UC1
    {
        public void CalLength(double x1, double y1, double x2, double y2)       //method create
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1,2));           //calculating length (x2-x1)^2
            double b = Math.Sqrt(Math.Pow(y2 - y1,2));           //Calculating (y2-y1)^2
            double c = a + b;                                    //Calculating length
            Console.WriteLine("Length of a line is :" + c);      //display the output
        }
    }
}
