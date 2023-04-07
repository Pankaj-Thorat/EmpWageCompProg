using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int empHrs = 0;
            const int empWageRate = 20;
            int empDailyWage = 0;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Comp Prob Statement");
            //UC1-ifPresentOrNot
            Random random = new Random();
            int empAttendence = random.Next(0, 3);
            if(empAttendence == isFullTime) 
            {
                Console.WriteLine("Employee is FullTime ");
                empHrs = 8;

            }
            else if (empAttendence == isPartTime)
            {
                Console.WriteLine("Employee is PartTime ");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empDailyWage = empHrs * empWageRate;
            Console.WriteLine("Employee Daily wage is: "+ empDailyWage +" rs");
        }
    }
}
