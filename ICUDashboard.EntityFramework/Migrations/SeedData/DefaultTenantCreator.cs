using System.Linq;
using ICUDashboard.EntityFramework;
using ICUDashboard.MultiTenancy;

namespace ICUDashboard.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ICUDashboardDbContext _context;

        public DefaultTenantCreator(ICUDashboardDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
