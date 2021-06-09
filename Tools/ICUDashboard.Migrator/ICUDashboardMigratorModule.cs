using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ICUDashboard.EntityFramework;

namespace ICUDashboard.Migrator
{
    [DependsOn(typeof(ICUDashboardDataModule))]
    public class ICUDashboardMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ICUDashboardDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}