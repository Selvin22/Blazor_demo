using Volo.Abp.Modularity;

namespace Blazor_demo;

/* Inherit from this class for your domain layer tests. */
public abstract class Blazor_demoDomainTestBase<TStartupModule> : Blazor_demoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
