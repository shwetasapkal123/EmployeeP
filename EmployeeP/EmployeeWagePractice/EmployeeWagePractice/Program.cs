using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePractice
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEL-COME\n");
            Console.WriteLine("\nEmployee Presenty");
            EmployeeAttendance.CheckingPresenty();
            Console.WriteLine("\nEmployee wage for 20 hrs\n");
            EmployeeWageSwitch.CalculateWage();
            Console.WriteLine("\nEmployee wage for 20days\n;");
            EmpWageFor.CalWageUsingFor();
            Console.WriteLine("Employee wage for max100 Hrs and 20 days\n");
            EmpWageWhile.CalWageUsingWhile();
            Console.ReadLine();
        }
    }
}
