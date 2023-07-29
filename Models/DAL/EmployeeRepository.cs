using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternMVC.Models.DAL
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private MVC_FormsEntities _dataContext;
        public EmployeeRepository(MVC_FormsEntities dataContext)
        {
            this._dataContext = dataContext;
        }
        public void DeleteEmployee(int EmployeeId)
        {
            Employee employee_ = _dataContext.Employees.Find(EmployeeId);
            _dataContext.Employees.Remove(employee_);
        }
        public Employee GetEmployeeById(int EmployeeId)
        {
            return _dataContext.Employees.Find(EmployeeId);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _dataContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee_)
        {
            _dataContext.Employees.Add(employee_);
        }
        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }
        public void UpdateEmployee(Employee employee_)
        {
            _dataContext.Entry(employee_).State = System.Data.Entity.EntityState.Modified;
        }
    }
}