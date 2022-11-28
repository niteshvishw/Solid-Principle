using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.BeforeLSP
{
    abstract class Bonus
    {
        public abstract double Salary();
        public abstract double CalculateBonus(double salary);

    }
    class CompanyEmployee : Bonus
    {
        public override double Salary()
        {
            return 10000;
        }
        public override double CalculateBonus(double salary)
        {
            return ((salary * 0.10) / 100);
        }
    }
    class ContractEmployee:Bonus
    {
        public override double Salary()
        {
            return 5000;
        }
        public override double CalculateBonus(double salary)
        {
            return 0;  
        }
    }
    class ThirdPartyEmployee: Bonus
    {
        public override double Salary()
        {
            return 5000;
        }
        public override double CalculateBonuds(double salary)
        {
            //return 0;
            //not applicable
            //In that case child class i
        }

    }

}
