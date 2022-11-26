using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.AfterOCP
{
    class Employee1
    {
        abstract class Bonus
        {
            public abstract double CalculateBonus(double salary);

        }
        class CompanyEmployee:Bonus
        {
            public override double CalculateBonus(double salary)
            {
                return ((salary * 0.10) / 100);
            }
        }
        class ContractEmployee:Bonus
        {
            public override double CalculateBonus(double salary)
            {
                return 0;
            }
        }
        class ThirdParty : Bonus
        {
            public override double CalculateBonus(double salary)
            {
                return 0;
            }
        }
    }
}
