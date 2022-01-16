using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class EmpWageBuilder : IWageComput
    {
        LinkedList<EmpWageCalculator> companyWageList;
        private EmpWageCalculator[] CompanyEmpWageArray;
        int numOfCompany = 0;
        public EmpWageBuilder()
        {
            this.companyWageList = new LinkedList<EmpWageCalculator>();
           // CompanyEmpWageArray = new EmpWageCalculator[7];
        }
       
        public void SetCompanyWage(String Company, int empRatePerHr,int empMaxWorkingDay, int empMaxWorkingHr)
        {
            EmpWageCalculator empWageCalculator = new EmpWageCalculator(Company, empRatePerHr, empMaxWorkingDay, empMaxWorkingHr);
          this.companyWageList.AddLast(empWageCalculator);
            numOfCompany++;
        }

        public void EmpMonthlyWage()
        {
            foreach(EmpWageCalculator empWageCalculator in this.companyWageList)
           // for (int i = 0; i < numOfCompany; i++)
            {

                empWageCalculator.setTotalWage(this.EmpMonthlyWageCalculator(empWageCalculator));
                Console.WriteLine(empWageCalculator.toString());
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