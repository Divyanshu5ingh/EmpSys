using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Acme.EmpSys;

public class EmpSysWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<EmpSysWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
