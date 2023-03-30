using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.EmpSys.Departments;

public class UpdateDepartmentDto
{
    [Required]
    [StringLength(DepartmentConsts.MaxNameLength)]
    public string Name { get; set; }

    public string ShortBio { get; set; }
}
