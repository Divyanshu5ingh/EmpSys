using Acme.EmpSys.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.EmpSys.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class EmpSysPageModel : AbpPageModel
{
    protected EmpSysPageModel()
    {
        LocalizationResourceType = typeof(EmpSysResource);
    }
}
