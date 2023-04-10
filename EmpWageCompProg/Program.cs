using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompProg
{
    internal class Program
    {
        const int isPartTime = 1;
        const int isFullTime = 2;
        const int numberOfWorkingDays = 20;
        const int empWageRate = 20;
        const int maxHrsInMonth = 100;

        static void Main(string[] args)
        {
            int totalEmpHrs = 0;
            int empHrs = 0;   
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Comp Prob Statement");
            //UC6-monthlyWageTillCondition
            while (totalWorkingDays < numberOfWorkingDays && totalEmpHrs < maxHrsInMonth )
            {
                totalWorkingDays++;
                Random random = new Random();
                int empAttendence = random.Next(0, 3);
                switch (empAttendence)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;

                    case isPartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                int empDailyWage = empHrs * empWageRate;
                totalEmpWage += empDailyWage;
                totalEmpHrs += empHrs;
                Console.WriteLine("total wage:" + totalEmpWage + "for "+ totalWorkingDays +" days and "+ totalEmpHrs +"hrs");
            }
            Console.WriteLine("Employee Total wage for {0} days and {1}hrs is {2} rs", totalWorkingDays,totalEmpHrs, totalEmpWage);
        }
    }
}
