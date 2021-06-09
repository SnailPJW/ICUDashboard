using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ICUDashboard.EntityFramework.Repositories
{
    public abstract class ICUDashboardRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ICUDashboardDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ICUDashboardRepositoryBase(IDbContextProvider<ICUDashboardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ICUDashboardRepositoryBase<TEntity> : ICUDashboardRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ICUDashboardRepositoryBase(IDbContextProvider<ICUDashboardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
