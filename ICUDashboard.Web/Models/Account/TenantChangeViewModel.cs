using Abp.AutoMapper;
using ICUDashboard.Sessions.Dto;

namespace ICUDashboard.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}