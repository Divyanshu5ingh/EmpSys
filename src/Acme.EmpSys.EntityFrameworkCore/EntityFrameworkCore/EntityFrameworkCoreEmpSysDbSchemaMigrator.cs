using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.EmpSys.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.EmpSys.EntityFrameworkCore;

public class EntityFrameworkCoreEmpSysDbSchemaMigrator
    : IEmpSysDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEmpSysDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EmpSysDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EmpSysDbContext>()
            .Database
            .MigrateAsync();
    }
}
