using Blazor_demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Blazor_demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Blazor_demoController : AbpControllerBase
{
    protected Blazor_demoController()
    {
        LocalizationResource = typeof(Blazor_demoResource);
    }
}
