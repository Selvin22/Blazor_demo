using System.Threading.Tasks;

namespace Blazor_demo.Data;

public interface IBlazor_demoDbSchemaMigrator
{
    Task MigrateAsync();
}
