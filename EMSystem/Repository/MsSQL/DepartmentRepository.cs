using EMSystem.Data;
using EMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Repository.MsSQL
{
    public class DepartmentRepository:IDepartmentRepository
    {
        EMSDbContext _context=new EMSDbContext();
        public Department GetDeptById(int Id)
        {
          
            return _context.departments.AsNoTracking().ToList().FirstOrDefault(d => d.DeptId == Id);
        }
        public List<Department> ListOfDepartment()
        {
            return _context.departments.AsNoTracking().ToList();
        }
        public Department AddDepartment(Department newDepartment)
        {
            _context.Add(newDepartment);
            _context.SaveChanges();
            return newDepartment;
        }
        public Department UpdateDepartment(int DeptId, Department newDept)
        {
            var dept = GetDeptById(DeptId);
            if (dept != null)
            {
                _context.departments.Update(newDept);
                _context.SaveChanges();
            }
            return newDept;
        }
        
        public Department DeleteDepartment(int DeptId)
        {
            var dept = GetDeptById(DeptId);
            if (dept != null)
            {
                _context.departments.Remove(dept);
                _context.SaveChanges();
            }
            return dept;
        }
    }
}
