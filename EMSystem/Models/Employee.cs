using EMSystem.Models;
using EMSystem.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMSystem.Models
{
    public class Employee
    {
        private int v1;
        private string v2;
        private DateTime dateTime;
        private string v3;
        private string v4;
        private int v5;

        [Key]
        public int EmpId { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(10)]
        public string Phone { get; set; }
        
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        public Employee()
        {

        }
        public Employee(int empId, string name, DateTime dOB, string email, string phone, int departmentId)
        {
            EmpId = empId;
            Name = name;
            DOB = dOB;
            Email = email;
            Phone = phone;
            DepartmentId = departmentId;
        }

       
    }
}
