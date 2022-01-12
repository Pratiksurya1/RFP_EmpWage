using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class Uc3
    {
        int isPartTime = 1;
        int isFullTime = 2;
        int empRatePerHr = 20;
        int empWorkHr;
        int empSalary;
        public void EmpWage()
        {
            Random random = new Random();
            int workType = random.Next(3);
            if (isPartTime == workType)
            {
                empWorkHr = 4;
                empSalary = empWorkHr * empRatePerHr;
            }
            else if (isFullTime == workType)
            {
                empWorkHr = 8;
                empSalary = empWorkHr * empRatePerHr;
            }
            Console.WriteLine("Emp work " + empWorkHr + " salary is " + empSalary);
        }
    }
}