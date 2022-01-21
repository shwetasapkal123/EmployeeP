using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePractice
{
     class EmpWageFor
    {
         const int IS_PART_TIME = 1;
         const int IS_FULL_TIME = 2;
         const int EMP_RATE_PER_HOUR = 20;      //20Rs for Each 1 hr
        const int NUM_OF_WORKING_DAYS = 20;     //Assuming for 20days work
        public static void CalWageUsingFor()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            for(int day=1; day<=NUM_OF_WORKING_DAYS;day++)
            {
                Random random = new Random();       //random input generating
                int empCheck = random.Next(0, 2);   //input take 0,1,2 case 1=part time case2=full time case0=default
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage for {0}day is {1}:",day,empWage);
            }
            Console.WriteLine("Employee wage for month is:"+totalEmpWage);
        }
    }
}
