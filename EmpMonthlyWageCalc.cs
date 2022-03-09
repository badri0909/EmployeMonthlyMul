using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpMonthlyWageCalc
    {
        public void EmpWageCalcWithHoursOrDays()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int EMP_DAYS_PER_MONTH = 20;
            int EMP_MAX_HOURS = 100;

            int emphrs = 0;
            int totalhrs = 0;
            int totalSalary = 0;
            int workingDays = 0;

            while (totalhrs < EMP_MAX_HOURS || workingDays < EMP_DAYS_PER_MONTH)
            {
                workingDays++;

                Random random = new Random();
                int num = random.Next(3);

                switch (num)
                {
                    case 0:
                        emphrs = 4;
                        break;
                    case 1:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalhrs = (totalhrs + emphrs);
                Console.WriteLine("Total Hourse= " + totalhrs);
            }
            totalSalary = (totalhrs * EMP_RATE_PER_HOUR);
            Console.WriteLine("Salary withrespect to Total Hours Present " + totalSalary);
        }
    }
}