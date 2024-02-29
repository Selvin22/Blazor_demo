using System;
using System.Collections.Generic;
using System.Text;
using Blazor_demo.Localization;
using Volo.Abp.Application.Services;

namespace Blazor_demo;

/* Inherit your application services from this class.
 */
public abstract class Blazor_demoAppService : ApplicationService
{
    protected Blazor_demoAppService()
    {
        LocalizationResource = typeof(Blazor_demoResource);
    }
}
