using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.BeforeOCP
{
    public class Employee
    {
        public double CalculateBonus(string emptype, double salary)
        {
            double bonus = 0;
            if (emptype == "CompanyEmployee")
            {
                bonus = ((salary * 10) / 100);
            }
            else if (emptype == "ContractEmployee")
            {
                bonus = 0;
            }
            else if (emptype == "ThirdParty")
            {
                bonus = 0;
            }
        }
    }

}
