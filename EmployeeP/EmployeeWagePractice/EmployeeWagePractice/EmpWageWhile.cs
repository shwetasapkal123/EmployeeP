using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePractice
{
     class EmpWageWhile
    {
        public static void CalWageUsingWhile()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;      //20Rs for Each 1 hr
            const int NUM_OF_WORKING_DAYS = 20;     //Assuming for 20days work
            const int MAX_HRS_IN_MONTH = 100;        //maximum working hours in one month is 100

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingDays<NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs+=empHrs;
                Console.WriteLine("Day"+totalWorkingDays+"Employee working Hrs"+empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage is:" + totalEmpWage);
        }
    }
}
