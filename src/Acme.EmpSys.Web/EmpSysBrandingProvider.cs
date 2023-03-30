using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.EmpSys.Web;

[Dependency(ReplaceServices = true)]
public class EmpSysBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EmpSys";
}
