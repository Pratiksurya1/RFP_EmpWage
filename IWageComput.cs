using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal interface IWageComput
    {
        public void SetCompanyWage(String Company, int empRatePerHr, int empMaxWorkingDay, int empMaxWorkingHr);
        public void EmpMonthlyWage();

    }
}
