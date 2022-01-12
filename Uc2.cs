using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class Uc2
    {
        int empSalary;
        public void CalculateWage()
        {
            Random random = new Random();
            int isPresent = random.Next(2);
            if (isPresent == 0)
            {
                int empRatePerHr = 20;
                int empWorkHr = 8;
                empSalary = empRatePerHr * empWorkHr;
                Console.WriteLine("emp is presant\n Emp Dialy Wage is " + empSalary);
            }
            else
                Console.WriteLine("emp is absent \n Emp Daily Wage is " + empSalary);
        }
    }
}