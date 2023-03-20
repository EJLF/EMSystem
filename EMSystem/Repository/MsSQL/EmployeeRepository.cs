using EMSystem.Data;
using EMSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Repository.MsSQL
{
    public class EmployeeRepository:IEmployeeRepository
    {
        List<Department> departmentList = new List<Department>();
        EMSDbContext _context= new EMSDbContext();
        public List<Employee> ListOfEmployee()
        {
            return _context.employees.AsNoTracking().ToList();
        }

        public List<SelectListItem> GetDepartmentList(int Empid)
        {

            var listDept = new List<SelectListItem>();
            List<Department> departments = _context.departments.ToList();
            listDept = departments.Select(dept => new SelectListItem
            {
                Value = (dept.DeptId).ToString(),
                Text = dept.DeptName
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "---Select Department---"
            };
            listDept.Insert(0, defItem);
            return listDept;
        }

        public Employee GetEmployeeById(int Id)
        {
            return _context.employees.Include(d => d.Department).AsNoTracking().ToList().FirstOrDefault(x => x.EmpId == Id);
        }
        public Employee AddEmployee(Employee newEmp)
        {
        
            _context.Add(newEmp);
            _context.SaveChanges();
            return newEmp;
        }
        public Employee DeleteEmployee(int Id)
        {
            var Emp = GetEmployeeById(Id);
            if (Emp != null)
            {
                _context.employees.Remove(Emp);
                _context.SaveChanges();
            }
            return Emp;
        }

        public Employee UpdateEmployee(Employee newEmployee)
        {
            _context.employees.Update(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public Employee UpdateEmployee(int EmployeeId, Employee newEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
