using EMSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMSystem.ViewModel
{
    public class EmployeeViewModel
    {
        public Employee Employees { get; set; }

        public IEnumerable<SelectListItem> ListDepartments { get; set; }
    }
}
