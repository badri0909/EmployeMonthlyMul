using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeAttendance
    {
        ///<summary>
        /// UC1- the employee present or not.
        ///</summary>
        public void PresentorAbsent()
        {
            Random random = new Random();
            int r = random.Next(2);

            if (r == 1)
            {
                Console.WriteLine("Emloyee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}