using System;
using System.Collections.Generic;
using System.Text;
using Acme.EmpSys.Localization;
using Volo.Abp.Application.Services;

namespace Acme.EmpSys;

/* Inherit your application services from this class.
 */
public abstract class EmpSysAppService : ApplicationService
{
    protected EmpSysAppService()
    {
        LocalizationResource = typeof(EmpSysResource);
    }
}
