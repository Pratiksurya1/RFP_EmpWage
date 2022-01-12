using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class Uc4
    {
        int empRatePerHr = 20;
        int empWorkHr;
        int empSalary;
        public void EmpWage()
        {
            Random random = new Random();
            int workType = random.Next(3);

            switch (workType)
            {
                case 1:
                    empWorkHr = 8;
                    break;
                case 2:
                    empWorkHr = 4;
                    break;
                default:
                    empWorkHr = 0;
                    break;
            }
            empSalary = empWorkHr * empRatePerHr;
            Console.WriteLine("Emp work " + empWorkHr + " salary is " + empSalary);
        }
    }
}