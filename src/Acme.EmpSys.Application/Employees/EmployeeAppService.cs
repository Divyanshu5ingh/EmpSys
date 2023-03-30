using Acme.EmpSys.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.EmpSys.Employees
{
    public class EmployeeAppService :
        CrudAppService<
            Employee,
            EmployeeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateEmployeeDto>,
        IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, Guid> repository)
        : base(repository)
        {
            GetPolicyName = EmpSysPermissions.Employees.Default;
            GetListPolicyName = EmpSysPermissions.Employees.Default;
            CreatePolicyName = EmpSysPermissions.Employees.Create;
            UpdatePolicyName = EmpSysPermissions.Employees.Edit;
            DeletePolicyName = EmpSysPermissions.Employees.Delete;
        }
    }
}
