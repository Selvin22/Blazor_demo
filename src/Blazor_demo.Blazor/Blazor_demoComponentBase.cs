using Blazor_demo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Blazor_demo.Blazor;

public abstract class Blazor_demoComponentBase : AbpComponentBase
{
    protected Blazor_demoComponentBase()
    {
        LocalizationResource = typeof(Blazor_demoResource);
    }
}
