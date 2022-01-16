using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class EmpWageCalculatot
    {
        int empRatePerHr = 20;
        int empMaxWorkingHr;
        int empMaxWorkingDay;
        String Company;
        int empTotalWage;

        public EmpWageCalculatot(String company, int empMaxWorkingHr, int empMaxWorkingDay, int empRatePerHr)
        {
            this.Company = company;
            this.empMaxWorkingDay = empMaxWorkingDay;
            this.empMaxWorkingHr = empMaxWorkingHr;
            this.empRatePerHr = empRatePerHr;                                       
        }
        public void EmpMonthlyWage()
        {
            int empWorkHr = 0;
            int totalEmpWorkDay = 0;
            int totalWorkhr = 0;
            while (empWorkHr < empMaxWorkingHr && totalEmpWorkDay < empMaxWorkingDay)
            {
                Random random = new Random();
                int workType = random.Next(0,3);
                totalEmpWorkDay++;

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
                totalWorkhr = totalWorkhr + empWorkHr;
                Console.WriteLine("Day : "+ totalEmpWorkDay+" Employee hrs : "+empWorkHr);
            }
           
                empTotalWage = totalWorkhr * empRatePerHr;
            Console.WriteLine("Emp Total Wage for "+Company+" Company : " + empTotalWage);
        
        }
        public String toString()
        {
            return "Emp Total Wage for " + this.Company + " Company : " + this.empTotalWage;
        }
    }
}