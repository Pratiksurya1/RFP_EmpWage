using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class Uc7
    {
        static int empRatePerHr = 20;
        static int empWorkHr = 0;
        static int empWorkDay = 0;
        static int empTotalSalary;
        static int totalWorkhr = 0;

        public void EmpMonthlyWage()
        {
            while (empWorkHr <= 100 && empWorkDay <= 20)
            {
                empWorkDay++;
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
            Console.WriteLine("Emp Total Wage is " + empTotalSalary);
        }
        public static void SalaryCaount(int empWorkHr)
        {
            totalWorkhr = totalWorkhr + empWorkHr;
            empTotalSalary = totalWorkhr * empRatePerHr;
        }
    }
}