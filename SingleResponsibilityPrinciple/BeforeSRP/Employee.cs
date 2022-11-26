using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.BeforeSRP
{
    public class Employee
    {
        // Responsible Actor - CFO (Chief Financial Officer)
        public decimal CalculatePay()
        {
            RegularHourse();
            Console.WriteLine("Calculate pay of employee");
            return 0;
        }

        // Responsible Actor - COO (Chief Operating Officer)
        public int ReportHouses()
        {
            RegularHourse();
            Console.WriteLine("Report Hours of Employee");
            return 0;
        }
        
        // Resposible Actor - CTO (Chief Technology Officer)
        public bool Save()
        {
            Console.WriteLine("Save Employee Data");
            return true;
        }

        private int RegularHourse()
        {
            Console.WriteLine("Calculate regular hours of employee");
            return 0;
        }
    }
}
