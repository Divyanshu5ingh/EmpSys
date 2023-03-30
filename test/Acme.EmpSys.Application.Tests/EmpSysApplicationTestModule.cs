using Volo.Abp.Modularity;

namespace Acme.EmpSys;

[DependsOn(
    typeof(EmpSysApplicationModule),
    typeof(EmpSysDomainTestModule)
    )]
public class EmpSysApplicationTestModule : AbpModule
{

}
