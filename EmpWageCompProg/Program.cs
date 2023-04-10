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
            int isPresent = 1;
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Comp Prob Statement");
            //UC1-ifPresentOrNot
            Random random = new Random();
            int empAttendence = random.Next(0, 2);
            if(empAttendence == 0) 
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
