using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Blazor_demo.Data;
using Volo.Abp.DependencyInjection;

namespace Blazor_demo.EntityFrameworkCore;

public class EntityFrameworkCoreBlazor_demoDbSchemaMigrator
    : IBlazor_demoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBlazor_demoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the Blazor_demoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Blazor_demoDbContext>()
            .Database
            .MigrateAsync();
    }
}
