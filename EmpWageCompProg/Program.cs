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


        static void Main(string[] args)
        {
            int empHrs = 0;
            int empDailyWage = 0;
            int totalEmpWage = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Comp Prob Statement");
            //UC5-monthlyWage
            for (int day = 1; day <= numberOfWorkingDays; day++)
            {
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
                empDailyWage = empHrs *empWageRate;
                totalEmpWage += empDailyWage;
                Console.WriteLine("Employee Daily wage for day{0} is: " + empDailyWage + " rs",day);
            }
            Console.WriteLine("Employee Total wage for {0} days is {1} rs", numberOfWorkingDays, totalEmpWage);
        }
    }
}
