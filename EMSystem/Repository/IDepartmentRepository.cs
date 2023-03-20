using EMSystem.Models;

namespace EMSystem.Repository
{
    public interface IDepartmentRepository
    {
        // Add Department
        Department AddDepartment(Department newDepartment);
        // GetAllDepartment
        List<Department> ListOfDepartment();
        // GetId
        Department GetDeptById(int Id);
        // Update
        Department UpdateDepartment(int DepartmentId, Department newDepartment);
        // Delete
        Department DeleteDepartment(int DepartmentId);
    }
}
