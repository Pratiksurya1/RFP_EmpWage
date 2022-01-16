using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    public class EmpWageCalculator
    {
       public int empRatePerHr = 20;
       public int empMaxWorkingHr;
       public int empMaxWorkingDay;
       public String Company;
       public int empTotalWage;

        public EmpWageCalculator(String Company, int empRatePerHr, int empMaxWorkingDay, int empMaxWorkingHr)
        {
            this.Company = Company;
            this.empMaxWorkingDay = empMaxWorkingDay;
            this.empMaxWorkingHr = empMaxWorkingHr;
            this.empRatePerHr = empRatePerHr;
        }
        public int setTotalWage(int totalWage)
        {
            this.empTotalWage = totalWage;
            return this.empTotalWage;
        }
        public String toString()
        {
            return "Emp Total Wage for " + this.Company + " Company : " + this.empTotalWage;
        }
    }
}
