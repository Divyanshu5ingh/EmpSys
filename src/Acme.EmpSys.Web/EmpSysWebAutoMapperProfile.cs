using Acme.EmpSys.Departments;
using Acme.EmpSys.Employees;
using AutoMapper;

namespace Acme.EmpSys.Web;

public class EmpSysWebAutoMapperProfile : Profile
{
    public EmpSysWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<EmployeeDto, CreateUpdateEmployeeDto>();

        CreateMap<Pages.Departments.CreateModalModel.CreateDepartmentViewModel,
                  CreateDepartmentDto>();

        // ADD THESE NEW MAPPINGS
        CreateMap<DepartmentDto, Pages.Departments.EditModalModel.EditDepartmentViewModel>();
        CreateMap<Pages.Departments.EditModalModel.EditDepartmentViewModel,
                  UpdateDepartmentDto>();

        CreateMap<Pages.Employees.CreateModalModel.CreateEmployeeViewModel, CreateUpdateEmployeeDto>();
        CreateMap<EmployeeDto, Pages.Employees.EditModalModel.EditEmployeeViewModel>();
        CreateMap<Pages.Employees.EditModalModel.EditEmployeeViewModel, CreateUpdateEmployeeDto>();

    }
}
