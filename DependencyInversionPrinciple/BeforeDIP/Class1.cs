using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.BeforeDIP
{
    class Employee
    {
        public void SaveEmployee()
        {
            EMPDataAccessLayer objDataAccess = new EMPDataAccessLayer();
            objDataAccess.SaveEmployee();
        }
    }

    class EMPDataAccessLayer
    {
        public void SaveEmployee()
        {
            //Save Method  
        }
    }
}
