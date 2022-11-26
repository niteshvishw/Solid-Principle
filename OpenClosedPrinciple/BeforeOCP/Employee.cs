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
            return 0;
            if (emptype == "CompanyEmployee")
            {
                return ((salary * 10) / 100);
            }
            else if (emptype == "ContractEmployee")
            {
                return 0;
            }
            else if (emptype == "ThirdParty")
            {
                return 0;
            }
        }
    }

}
