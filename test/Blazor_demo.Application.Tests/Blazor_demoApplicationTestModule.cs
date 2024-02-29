using Volo.Abp.Modularity;

namespace Blazor_demo;

[DependsOn(
    typeof(Blazor_demoApplicationModule),
    typeof(Blazor_demoDomainTestModule)
)]
public class Blazor_demoApplicationTestModule : AbpModule
{

}
