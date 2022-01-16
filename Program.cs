using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_EmpWage
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            EmpWageBuilder addCompany = new EmpWageBuilder();
            addCompany.SetCompanyWage("Tata",28,3,40);
            addCompany.SetCompanyWage("Ford",18,4, 30);
            addCompany.EmpMonthlyWage();

           // Console.WriteLine(addCompany.ToString());

            //Uc6 uc6 = new Uc6();
            //uc6.EmpMonthlyWage();

            //Uc5 uc5 = new Uc5();
            //uc5.EmpMonthlyWage();

            //Uc4 uc4 = new Uc4();
            //uc4.EmpWage();

            //Uc3 uc3 = new Uc3();
            //uc3.EmpWage();

            //Uc2 uc2 = new Uc2();
            //uc2.CalculateWage();

            //Uc1 uc1 = new Uc1();
            //uc1.Attendance();
        }
    }
}