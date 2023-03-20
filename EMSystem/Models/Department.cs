using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMSystem.Models
{
    public class Department
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }

     //   [Index(IsUnique = true)]
        [Required]
        
        public string DeptName { get; set; }
        public Department()
        {

        }
        public Department(int deptId, string deptName)
        {
            DeptId = deptId;
            DeptName = deptName;
        }
    }
}
