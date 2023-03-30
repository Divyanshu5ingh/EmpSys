using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.EmpSys.Employees;

public interface IEmployeeAppService :
    ICrudAppService<
        EmployeeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateEmployeeDto>

{
}
