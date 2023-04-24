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
            Employee employee = new Employee();
            employee.EmployeeWage();
        }
    }
}
