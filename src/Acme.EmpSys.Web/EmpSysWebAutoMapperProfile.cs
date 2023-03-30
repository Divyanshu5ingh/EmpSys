using Acme.EmpSys.Employees;
using AutoMapper;

namespace Acme.EmpSys.Web;

public class EmpSysWebAutoMapperProfile : Profile
{
    public EmpSysWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<EmployeeDto, CreateUpdateEmployeeDto>();
    }
}
