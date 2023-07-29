using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternMVC.Models.DAL
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int EmployeeId);
        void InsertEmployee(Employee employee_);
        void UpdateEmployee(Employee employee_);
        void DeleteEmployee(int EmployeeId);
        void SaveChanges();
    }
}
