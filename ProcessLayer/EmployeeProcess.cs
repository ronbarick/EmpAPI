using DataLayer;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLayer
{
    public class EmployeeProcess:IEmployeeProcess
    {
        private readonly EmployeeDbContext _context;
        public EmployeeProcess(EmployeeDbContext _db)
        {

            this._context = _db;
        }



        public List<Employee> getEmployeeData()
        {
            try
            {

                return _context.tbl_Employee.Select(s=> new Employee {age=s.age,Id=s.Id,Name=s.Name,salary=s.salary}).ToList();
                 
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        public bool PostEmplyee(Employee emp)
         {
            try
            {
                if (emp.Id != 0)
                {
                    var data = _context.tbl_Employee.FirstOrDefault(a => a.Id == emp.Id);
                    if (data != null)
                    {
                        data.salary = emp.salary;
                        data.age = emp.age;
                        data.Name = emp.Name;
                        
                        _context.Entry(data).State = EntityState.Modified;
                        _context.SaveChanges();
                    }


                }
                else
                {
                    _context.tbl_Employee.Add(emp);
                    _context.SaveChanges();
                }
              
           
                return true;



            }
            catch (Exception ex)
            {
                return false;
                throw;
            }


        }

        public bool DeleteEmployee(Employee emp)
        {
            try
            {
                _context.tbl_Employee.Remove(emp);
                _context.SaveChanges();
                return true;



            }
            catch (Exception ex)
            {
                return false;
                throw;
            }


        }
    }
}
