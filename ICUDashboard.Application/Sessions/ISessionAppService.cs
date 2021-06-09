using System.Threading.Tasks;
using Abp.Application.Services;
using ICUDashboard.Sessions.Dto;

namespace ICUDashboard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
