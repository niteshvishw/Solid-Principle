using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.AfterSRP
{
    public class EmployeeSaver
    {
        public bool save()
        {
            Console.WriteLine("Save Employee Data");
            return true;
        }

        internal void Saver()
        {
            throw new NotImplementedException();
        }
    }
}
