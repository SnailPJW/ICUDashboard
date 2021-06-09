using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ICUDashboard.MultiTenancy.Dto;

namespace ICUDashboard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
