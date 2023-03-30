using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.EmpSys.Employees
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(18, 70)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        
        [Required]
        public float Salary { get; set; }
    }
}
