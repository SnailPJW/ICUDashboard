using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ICUDashboard.Configuration.Dto;

namespace ICUDashboard.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ICUDashboardAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
