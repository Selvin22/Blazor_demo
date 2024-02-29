using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Blazor_demo.Blazor;

[Dependency(ReplaceServices = true)]
public class Blazor_demoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blazor_demo";
}
