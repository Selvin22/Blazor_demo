using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Blazor_demo.Data;

/* This is used if database provider does't define
 * IBlazor_demoDbSchemaMigrator implementation.
 */
public class NullBlazor_demoDbSchemaMigrator : IBlazor_demoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
