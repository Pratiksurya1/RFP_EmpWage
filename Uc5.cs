using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class Uc5
    {
        static int empRatePerHr = 20;
        static int empWorkHr;
        static int empSalary = 0;
        static int totalSalary = 0;
        public void EmpMonthlyWage()
        {
            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int workType = random.Next(3);

                switch (workType)

                {
                    case 1:
                        empWorkHr = 8;
                        SalaryCaount(empWorkHr);
                        break;
                    case 2:
                        empWorkHr = 4;
                        SalaryCaount(empWorkHr);
                        break;
                    default:
                        empWorkHr = 0;
                        SalaryCaount(empWorkHr);
                        break;
                }
            }
            Console.WriteLine("Emp monthly Wage is " + totalSalary);
        }
        public static void SalaryCaount(int empWorkHr)
        {
            empSalary = empWorkHr * empRatePerHr;
            totalSalary = totalSalary + empSalary;

        }
    }
}