using Volo.Abp.Application.Dtos;

namespace Acme.EmpSys.Departments;

public class GetDepartmentListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}

