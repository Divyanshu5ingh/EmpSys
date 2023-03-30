using Volo.Abp.Settings;

namespace Acme.EmpSys.Settings;

public class EmpSysSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EmpSysSettings.MySetting1));
    }
}
