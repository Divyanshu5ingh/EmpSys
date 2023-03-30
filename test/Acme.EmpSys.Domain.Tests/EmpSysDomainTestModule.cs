using Acme.EmpSys.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.EmpSys;

[DependsOn(
    typeof(EmpSysEntityFrameworkCoreTestModule)
    )]
public class EmpSysDomainTestModule : AbpModule
{

}
