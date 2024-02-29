using Volo.Abp.Modularity;

namespace Blazor_demo;

[DependsOn(
    typeof(Blazor_demoDomainModule),
    typeof(Blazor_demoTestBaseModule)
)]
public class Blazor_demoDomainTestModule : AbpModule
{

}
