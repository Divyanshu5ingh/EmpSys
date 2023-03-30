using System.Threading.Tasks;
using Acme.EmpSys.Employees;
using Microsoft.AspNetCore.Mvc;

namespace Acme.EmpSys.Web.Pages.Employees;

public class CreateModalModel : EmpSysPageModel
{
    [BindProperty]
    public CreateUpdateEmployeeDto Employee { get; set; }

    private readonly IEmployeeAppService _employeeAppService;

    public CreateModalModel(IEmployeeAppService employeeAppService)
    {
        _employeeAppService = employeeAppService;
    }

    public void OnGet()
    {
        Employee = new CreateUpdateEmployeeDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _employeeAppService.CreateAsync(Employee);
        return NoContent();
    }
}
