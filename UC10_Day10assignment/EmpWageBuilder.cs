using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10_Day9
{
    class EmpWageBuilderArray
    {


            public const int PartTime = 1;
            public const int FullTime = 2;

            public int NumofCompany = 0;
            private CompanyEmpWage[] CompanyWageArray;

            public EmpWageBuilderArray()
            {
                this.CompanyWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string Company, int EmpRatePerHr, int TotalWorkingDays, int TotalWorkingHrs)
            {
                CompanyWageArray[this.NumofCompany] = new CompanyEmpWage(Company, EmpRatePerHr, TotalWorkingDays, TotalWorkingHrs)
                NumofCompany++;
            }
            public void computeWage()
            {
                for (int i = 0; i < NumofCompany; i++)
                {
                    CompanyWageArray[i].setTotalEmpWage(this.computeEmpWage(this.CompanyWageArray[i]));
                    Console.WriteLine(this.CompanyWageArray[i].toString());
                }
            }
            private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                int EmpHrs = 0, TotalEmpHrs = 0, TotalWorkingDay = 0;
                while (TotalEmpHrs <= companyEmpWage.TotalWorkingHrs && TotalWorkingDay < companyEmpWage.TotalWorkingDays)
                {
                    TotalWorkingDay++;
                    Random R = new Random();
                    int EmpCheck = R.Next(0, 3);
                    switch (EmpCheck)
                    {
                        case PartTime:
                            EmpHrs = 4;
                            break;
                        case FullTime:
                            EmpHrs = 8;
                            break;
                        default:
                            EmpHrs = 0;
                            break;
                    }
                    TotalEmpHrs += EmpHrs;
                    Console.WriteLine("days: " + TotalWorkingDay + " EmpHrs " + EmpHrs);
                }
                return TotalEmpHrs * companyEmpWage.EmpRatePerHr;
            }
        }
    }
