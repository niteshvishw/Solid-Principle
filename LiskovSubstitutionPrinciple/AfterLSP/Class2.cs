using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.AfterLSP
{
    interface Salary
    {
        double Salary();
    }
    interface Bonus
    {
        double CalculateBonus(double Salary);
    }
    class CompanyEmployee:Salary,Bonus
    {
        public double Salary()
        {
            return 10000;
        }
        public double CalculateBonus(double Salary)
        {
            return ((Salary * 0.10) / 100);
        }

    }
    class ContractEmployee : Salary, Bonus
    {
        public double Salary()
        {
            return 5000;
        }
        public double CalculateBonus(double salary)
        {
            return 0;
        }
    }
}
