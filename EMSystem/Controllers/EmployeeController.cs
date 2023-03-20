using EMSystem.Data;
using EMSystem.Models;
using EMSystem.Repository.MsSQL;
using EMSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository _repo = new EmployeeRepository();
        EMSDbContext _context = new EMSDbContext();
        public IActionResult List()
        {
            List<Employee> employees = _context.employees
                .Include(d => d.Department)
                .ToList();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            EmployeeViewModel employeeCreateModel = new EmployeeViewModel();
            employeeCreateModel.Employees = new Employee();
            List<SelectListItem> departments = _context.departments
                .OrderBy(n => n.DeptName)
                .Select(n => new SelectListItem
                {
                    Value = (n.DeptId).ToString(),
                    Text = n.DeptName
                }).ToList();
            employeeCreateModel.ListDepartments = departments;
            return View(employeeCreateModel);
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel newEmp)
        {
            _context.Add(newEmp.Employees);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Details(int Empid)
        {
            var emp = _repo.GetEmployeeById(Empid);
            return View(emp);
        }
        public IActionResult Delete(int Empid)
        {
            _repo.DeleteEmployee(Empid);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int Empid)
        {
            Employee employee = _repo.GetEmployeeById(Empid); ;
            ViewBag.DepartmentId = _repo.GetDepartmentList(Empid);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee newEmployee)
        {
            _repo.UpdateEmployee(newEmployee);
            return RedirectToAction("List");
        }
    }
}
