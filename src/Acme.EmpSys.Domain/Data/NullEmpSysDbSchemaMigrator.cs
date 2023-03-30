using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.EmpSys.Data;

/* This is used if database provider does't define
 * IEmpSysDbSchemaMigrator implementation.
 */
public class NullEmpSysDbSchemaMigrator : IEmpSysDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
