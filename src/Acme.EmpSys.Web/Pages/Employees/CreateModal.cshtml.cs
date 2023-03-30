using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Acme.EmpSys.Employees;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.EmpSys.Web.Pages.Employees;

public class CreateModalModel : EmpSysPageModel
{
    [BindProperty]
    public CreateEmployeeViewModel Employee { get; set; }

    public List<SelectListItem> Departments { get; set; }

    private readonly IEmployeeAppService _employeeAppService;

    public CreateModalModel(
        IEmployeeAppService employeeAppService)
    {
        _employeeAppService = employeeAppService;
    }

    public async Task OnGetAsync()
    {
        Employee = new CreateEmployeeViewModel();

        var departmentLookup = await _employeeAppService.GetDepartmentLookupAsync();
        Departments = departmentLookup.Items
            .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
            .ToList();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _employeeAppService.CreateAsync(
            ObjectMapper.Map<CreateEmployeeViewModel, CreateUpdateEmployeeDto>(Employee)
            );
        return NoContent();
    }

    public class CreateEmployeeViewModel
    {
        [SelectItems(nameof(Departments))]
        [DisplayName("Department")]
        public Guid DepartmentId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [Range(18, 70)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; } = DateTime.Now;

        [Required]
        public float Salary { get; set; }
    }
}
