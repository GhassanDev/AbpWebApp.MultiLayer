using Volo.Abp.Settings;

namespace WebApp.MultiLayer.Settings;

public class MultiLayerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MultiLayerSettings.MySetting1));
    }
}
