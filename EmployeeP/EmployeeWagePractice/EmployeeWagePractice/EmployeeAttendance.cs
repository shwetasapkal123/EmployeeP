using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePractice
{
     class EmployeeAttendance
    {
        public static void CheckingPresenty()
        {
            Random random = new Random();
            int fullTimeEmployee = 1;
            int randomInput = random.Next(0, 2);    //Generating random input
            if(randomInput==fullTimeEmployee)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
