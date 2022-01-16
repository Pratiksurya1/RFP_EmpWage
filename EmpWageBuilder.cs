using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class EmpWageBuilder
    {
        private EmpWageCalculator[] CompanyEmpWageArray;
        int numOfCompany = 0;
        public EmpWageBuilder()
        {
            CompanyEmpWageArray = new EmpWageCalculator[7];
        }
       
        public void SetCompanyWage(String Company, int empRatePerHr,int empMaxWorkingDay, int empMaxWorkingHr)
        {
            CompanyEmpWageArray[numOfCompany] = new EmpWageCalculator(Company, empRatePerHr, empMaxWorkingDay, empMaxWorkingHr);
            numOfCompany++;
        }

        public void EmpMonthlyWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {

                CompanyEmpWageArray[i].setTotalWage(this.EmpMonthlyWageCalculator(this.CompanyEmpWageArray[i]));
                Console.WriteLine(" Emp Total Wage for " + CompanyEmpWageArray[i].Company + " Company : " + CompanyEmpWageArray[i].empTotalWage);
            }
        }
        private int EmpMonthlyWageCalculator(EmpWageCalculator empWageCalculator)
        {
            int empWorkHr = 0;
            int totalEmpWorkDay = 0;
            int totalWorkhr = 0;
            while (empWorkHr < empWageCalculator.empMaxWorkingHr && totalEmpWorkDay < empWageCalculator.empMaxWorkingDay)
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
                
                return totalWorkhr * empWageCalculator.empRatePerHr;
         
        }
    }
}