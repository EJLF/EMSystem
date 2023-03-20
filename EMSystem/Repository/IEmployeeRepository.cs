using EMSystem.Models;

namespace EMSystem.Repository
{
    public interface IEmployeeRepository
    {
        // Add Employee
        Employee AddEmployee(Employee newEmployee);
        // GetAllEmployee
        List<Employee> ListOfEmployee();
        // GetId
        Employee GetEmployeeById(int Id);
        // Update
        Employee UpdateEmployee(int EmployeeId, Employee newEmployee);
        // Delete
        Employee DeleteEmployee(int EmployeeId);
    }
}
