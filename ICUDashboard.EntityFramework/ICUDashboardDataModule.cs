using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ICUDashboard.EntityFramework;

namespace ICUDashboard
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ICUDashboardCoreModule))]
    public class ICUDashboardDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ICUDashboardDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
