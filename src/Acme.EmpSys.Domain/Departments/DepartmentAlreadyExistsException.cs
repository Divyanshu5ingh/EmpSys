using Volo.Abp;

namespace Acme.EmpSys.Departments;

public class DepartmentAlreadyExistsException : BusinessException
{
    public DepartmentAlreadyExistsException(string name)
        : base(EmpSysDomainErrorCodes.DepartmentAlreadyExists)
    {
        WithData("name", name);
    }
}
