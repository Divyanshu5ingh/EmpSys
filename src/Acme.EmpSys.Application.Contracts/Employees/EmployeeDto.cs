using System;
using Volo.Abp.Application.Dtos;

namespace Acme.EmpSys.Employees;

public class EmployeeDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public DateTime JoinDate { get; set; }
    public float Salary { get; set; }
}
