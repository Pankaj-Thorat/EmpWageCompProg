using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompProg
{
    internal class Employee
    {
        private const int isPartTime = 1;
        private const int isFullTime = 2;
        private const int numberOfWorkingDays = 20;
        private const int empWageRate = 20;
        private const int maxHrsInMonth = 100;

        private int totalEmpHrs = 0;
        private int totalEmpWage = 0;
        private int totalWorkingDays = 0;

        public void EmployeeWage()
        {
            Console.WriteLine("Welcome to Employee Wage Comp Prob Statement");

            Random random = new Random();

            while (totalWorkingDays < numberOfWorkingDays && totalEmpHrs < maxHrsInMonth)
            {
                totalWorkingDays++;
                int empAttendence = random.Next(0, 3);

                switch (empAttendence)
                {
                    case isFullTime:
                        totalEmpHrs += 8;
                        break;

                    case isPartTime:
                        totalEmpHrs += 4;
                        break;

                    default:
                        totalEmpHrs += 0;
                        break;
                }
                int empDailyWage = totalEmpHrs * empWageRate;
                totalEmpWage = empDailyWage;
                Console.WriteLine("total wage:" + totalEmpWage + " for " + totalWorkingDays + " days and " + totalEmpHrs + " hrs");
            }
            Console.WriteLine("Employee Total wage for {0} days and {1} hrs is {2} rs", totalWorkingDays, totalEmpHrs, totalEmpWage);
        }
    }
}
