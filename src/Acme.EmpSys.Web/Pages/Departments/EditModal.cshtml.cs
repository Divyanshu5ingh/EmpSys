using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Acme.EmpSys.Departments;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.EmpSys.Web.Pages.Departments;

public class EditModalModel : EmpSysPageModel
{
    [BindProperty]
    public EditDepartmentViewModel Department { get; set; }

    private readonly IDepartmentAppService _departmentAppService;

    public EditModalModel(IDepartmentAppService departmentAppService)
    {
        _departmentAppService = departmentAppService;
    }

    public async Task OnGetAsync(Guid id)
    {
        var departmentDto = await _departmentAppService.GetAsync(id);
        Department = ObjectMapper.Map<DepartmentDto, EditDepartmentViewModel>(departmentDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _departmentAppService.UpdateAsync(
            Department.Id,
            ObjectMapper.Map<EditDepartmentViewModel, UpdateDepartmentDto>(Department)
        );

        return NoContent();
    }

    public class EditDepartmentViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [StringLength(DepartmentConsts.MaxNameLength)]
        public string Name { get; set; }

        [TextArea]
        public string ShortBio { get; set; }
    }
}
