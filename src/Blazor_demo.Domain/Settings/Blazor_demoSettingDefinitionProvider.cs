using Volo.Abp.Settings;

namespace Blazor_demo.Settings;

public class Blazor_demoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Blazor_demoSettings.MySetting1));
    }
}
