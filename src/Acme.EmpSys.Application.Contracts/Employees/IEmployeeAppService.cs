using System;
using System.Threading.Tasks;
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
    // ADD the NEW METHOD
    Task<ListResultDto<DepartmentLookupDto>> GetDepartmentLookupAsync();
}
