using System;
using Volo.Abp.Application.Dtos;

namespace Acme.EmpSys.Departments;

public class DepartmentDto : EntityDto<Guid>
{
    public string Name { get; set; }
    public string ShortBio { get; set; }
}

