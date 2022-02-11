using Volo.Abp.Settings;

namespace Mias.Practice.Settings;

public class PracticeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PracticeSettings.MySetting1));
    }
}
