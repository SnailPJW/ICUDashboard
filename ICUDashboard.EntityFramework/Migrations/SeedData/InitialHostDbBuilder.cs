using ICUDashboard.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ICUDashboard.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ICUDashboardDbContext _context;

        public InitialHostDbBuilder(ICUDashboardDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
