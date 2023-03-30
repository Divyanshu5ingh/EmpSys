using System;
using Volo.Abp.Application.Dtos;

namespace Acme.EmpSys.Employees;

public class DepartmentLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}
