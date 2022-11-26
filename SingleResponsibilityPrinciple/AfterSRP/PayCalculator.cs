using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class PayCalculator
    {
        public decimal CalculatePay()
        {
            RegularHourse();
            Console.WriteLine("Calculate Pay of employee");
            return 0;
        }

        private int RegularHourse()
        {
            Console.WriteLine("Calculate Regular hour of employee");
            return 0;
        }
    }
}
  