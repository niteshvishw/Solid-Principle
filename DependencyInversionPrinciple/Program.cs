using DependencyInversionPrinciple.BeforeDIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    //DIP says high-level modules should not depend on low-level modules.
    //Instead, both should depend on abstractions(interfaces).
    class Program
    {
        static void Main(string[] args)
        {
            // OLD
            Employee objEmp = new Employee();
            objEmp.SaveEmployee();

            //New
            //var Emp = new Employee(new EMPDataAccessLayer());
            //Emp.SaveEmployee();
        }
    }
}
   