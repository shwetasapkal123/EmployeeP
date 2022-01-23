using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC2
    {
        public static void CompareLine()
        {
            int x1, y1, x2, y2,x3,y3,x4,y4;                 //defining line points
            double firstLength, secLength;
            Console.WriteLine("Enter X1 point");            //take input from user
            x1=Convert.ToInt32(Console.ReadLine());         //read user input and convert it to integer bcz in C# default input is in string
            Console.WriteLine("Enter y1 point");           //take input from user
            y1 =Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer
            Console.WriteLine("Enter X2 point");            //take input from user
            x2 = Convert.ToInt32(Console.ReadLine());       //read user input and convert it to integer
            Console.WriteLine("Enter Y2 point");            //take input from user
            y2 = Convert.ToInt32(Console.ReadLine());       //read user input and convert it to integer
            Console.WriteLine("Enter X3 point");            //take input from user
            x3 = Convert.ToInt32(Console.ReadLine());       //read user input and convert it to integer
            Console.WriteLine("Enter y3 point");            //take input from user
            y3= Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer
            Console.WriteLine("Enter X4 point");            //take input from user
            x4= Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer
            Console.WriteLine("Enter Y4 point");            //take input from user
            y4= Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer

            firstLength=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));     //Calculating length of first two lines
            Console.WriteLine("first Length is:" + Math.Round(firstLength, 2)); //Result of line round to two digit after decimal and display 
            secLength=Math.Sqrt(Math.Pow(x4-x3,2)+Math.Pow(y4-y3,2));           //Calculating length
            Console.WriteLine("Second Length is :"+Math.Round(secLength, 2));   //Result round two two decimal points and display 

            Console.WriteLine("\nUsing Equal Method\n");
            if (firstLength.Equals(secLength))                              //Checking first length and second length equal or not and display
                Console.WriteLine("Length of the line is equal");
            else
                Console.WriteLine("length of the line is not equal");
        }
        
    }
}
