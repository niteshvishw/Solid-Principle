using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class HourReporter
    {
        public int ReportHours()
        {
            RegularHours();
            Console.WriteLine("Report hours of employee");
            return 0;
        }

        private int RegularHours()
        {
            Console.WriteLine("Calculate regular hours of employee");
            return 0;
        }
    }
}
