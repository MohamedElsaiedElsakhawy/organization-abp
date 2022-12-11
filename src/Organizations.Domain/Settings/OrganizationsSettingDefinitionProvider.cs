using Volo.Abp.Settings;

namespace Organizations.Settings;

public class OrganizationsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OrganizationsSettings.MySetting1));
    }
}
