using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EBANK.Configuration.Dto;

namespace EBANK.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EBANKAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
