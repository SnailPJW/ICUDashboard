using Abp.Authorization;
using ICUDashboard.Authorization.Roles;
using ICUDashboard.Authorization.Users;

namespace ICUDashboard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
