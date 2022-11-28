using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.AfterDIp
{
    public interface IEMDataAccessLayer
    {
        public void SaveEmployee();
    }

    public class EMPDataAccessLayer : IEMDataAccessLayer
    {
        public void SaveEmployee()
        {
            //Code for save Employee
        }
    }

    public class Employee
    {
        private readonly IEMDataAccessLayer _EMPDataAccessLayer;
        public Employee(IEMDataAccessLayer EMPDataAccessLayer)
        {
            _EMPDataAccessLayer= EMPDataAccessLayer;
        }
        public void SaveEmployee()
        {
            _EMPDataAccessLayer.SaveEmployee();
        }
    }
}
