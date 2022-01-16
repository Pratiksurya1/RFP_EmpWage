using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class EmpWageBuilder : IWageComput
    {
        private LinkedList<EmpWageCalculator> companyWageList;
        private Dictionary<string, EmpWageCalculator> ComppanyEmpWageDic;
        private EmpWageCalculator[] CompanyEmpWageArray;
        int numOfCompany = 0;
        int dailyWage;
        public EmpWageBuilder()
        {
            this.companyWageList = new LinkedList<EmpWageCalculator>();
            this.ComppanyEmpWageDic = new Dictionary<string,EmpWageCalculator>();
           // CompanyEmpWageArray = new EmpWageCalculator[7];
        }
       
        public void SetCompanyWage(String Company, int empRatePerHr,int empMaxWorkingDay, int empMaxWorkingHr)
        {
            EmpWageCalculator empWageCalculator = new EmpWageCalculator(Company, empRatePerHr, empMaxWorkingDay, empMaxWorkingHr);
          this.companyWageList.AddLast(empWageCalculator);
            this.ComppanyEmpWageDic.Add(Company, empWageCalculator);
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
                totalWorkhr += empWorkHr;
                dailyWage= empWorkHr*empWageCalculator.empRatePerHr;
                Console.WriteLine("Daily Wage : "+dailyWage);
            }
            return totalWorkhr * empWageCalculator.empRatePerHr;
         
        }
            public int totalWage(String Company)
        {
           return _ = this.ComppanyEmpWageDic[Company].empTotalWage;
        }
    }
}