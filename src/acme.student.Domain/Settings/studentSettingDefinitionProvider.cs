using Volo.Abp.Settings;

namespace acme.student.Settings;

public class studentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(studentSettings.MySetting1));
    }
}
