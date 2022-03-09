using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWagePerMonth
    {
        public void CalEmployeeWagePerMonth()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int EMP_DAYS_PER_MONTH = 20;

            int empHrs = 0;
            int empWagePerMonth = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWagePerMonth = (empHrs * EMP_RATE_PER_HOUR) * EMP_DAYS_PER_MONTH;
            Console.WriteLine("Emp Wage Per Month : " + empWagePerMonth);
        }
    }
}