using Acme.EmpSys.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.EmpSys.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EmpSysController : AbpControllerBase
{
    protected EmpSysController()
    {
        LocalizationResource = typeof(EmpSysResource);
    }
}
