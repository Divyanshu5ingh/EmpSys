using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.EmpSys.Departments;

public interface IDepartmentRepository : IRepository<Department, Guid>
{
    Task<Department> FindByNameAsync(string name);

    Task<List<Department>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null
    );
}
