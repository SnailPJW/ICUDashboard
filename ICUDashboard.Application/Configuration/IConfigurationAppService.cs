using System.Threading.Tasks;
using Abp.Application.Services;
using ICUDashboard.Configuration.Dto;

namespace ICUDashboard.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}