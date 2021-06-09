using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using ICUDashboard.Authorization.Users;
using ICUDashboard.MultiTenancy;
using ICUDashboard.Users;
using Microsoft.AspNet.Identity;

namespace ICUDashboard
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ICUDashboardAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ICUDashboardAppServiceBase()
        {
            LocalizationSourceName = ICUDashboardConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}