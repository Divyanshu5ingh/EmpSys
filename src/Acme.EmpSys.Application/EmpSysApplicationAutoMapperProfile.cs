using Acme.EmpSys.Employees;
using AutoMapper;

namespace Acme.EmpSys;

public class EmpSysApplicationAutoMapperProfile : Profile
{
    public EmpSysApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Employee, EmployeeDto>();
        CreateMap<CreateUpdateEmployeeDto, Employee>();
    }
}
