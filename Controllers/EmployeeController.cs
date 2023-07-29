using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RepositoryPatternMVC.Models;
using RepositoryPatternMVC.Models.DAL;

namespace RepositoryPatternMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController()
        {
            this._employeeRepository = new EmployeeRepository(new MVC_FormsEntities());
        }
        public ActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            return View(_employeeRepository.GetEmployeeById(id));
        }

        public ActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _employeeRepository.InsertEmployee(employee);
            _employeeRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int Id)
        {
            return View(_employeeRepository.GetEmployeeById(Id));
        }
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
            _employeeRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            _employeeRepository.DeleteEmployee(Id);
            _employeeRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}