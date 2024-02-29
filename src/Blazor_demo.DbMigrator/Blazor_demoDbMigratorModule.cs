using Blazor_demo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Blazor_demo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Blazor_demoEntityFrameworkCoreModule),
    typeof(Blazor_demoApplicationContractsModule)
    )]
public class Blazor_demoDbMigratorModule : AbpModule
{
}
