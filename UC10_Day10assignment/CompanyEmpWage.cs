using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10_Day9
{
    class CompanyEmpWage
    {
        public string Company;
        public int EmpRatePerHr;
        public int TotalWorkingDays;
        public int TotalWorkingHrs;
        public int TotalEmpWage;

        public CompanyEmpWage(string Company, int EmpRatePerHr, int TotalWorkingDays, int TotalWorkingHrs)
        {
            this.Company = Company;
            this.EmpRatePerHr = EmpRatePerHr;
            this.TotalWorkingDays = TotalWorkingDays;
            this.TotalWorkingHrs = TotalWorkingHrs;
        }
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }
        public string toString()
        {
            return "Total Employee Wage For Company" + Company + " is " + TotalEmpWage;
        }
    }
}




