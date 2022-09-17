using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLayer
{
    public interface IEmployeeProcess
    {
        bool DeleteEmployee(Employee emp);
        public List<Employee> getEmployeeData();
        bool PostEmplyee(Employee emp);
    }
}
