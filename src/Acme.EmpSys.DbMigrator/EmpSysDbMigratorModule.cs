using Acme.EmpSys.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.EmpSys.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EmpSysEntityFrameworkCoreModule),
    typeof(EmpSysApplicationContractsModule)
    )]
public class EmpSysDbMigratorModule : AbpModule
{

}
