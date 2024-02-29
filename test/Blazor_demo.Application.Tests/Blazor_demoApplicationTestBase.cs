using Volo.Abp.Modularity;

namespace Blazor_demo;

public abstract class Blazor_demoApplicationTestBase<TStartupModule> : Blazor_demoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
