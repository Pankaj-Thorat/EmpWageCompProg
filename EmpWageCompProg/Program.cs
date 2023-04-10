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
        static void Main(string[] args)
        {
           
            int empHrs = 0;
            const int empWageRate = 20;
            int empDailyWage = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Comp Prob Statement");
            //UC4-Used switch case
            Random random = new Random();
            int empAttendence = random.Next(0, 3);
            switch (empAttendence) 
            {
                case isFullTime:
                    Console.WriteLine("Employee is FullTime ");
                    empHrs = 8;
                    break;
                case isPartTime:
                    Console.WriteLine("Employee is PartTime ");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            empDailyWage = empHrs * empWageRate;
            Console.WriteLine("Employee Daily wage is: "+ empDailyWage +" rs");
        }
    }
}
