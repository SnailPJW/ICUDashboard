using Abp.Web.Mvc.Views;

namespace ICUDashboard.Web.Views
{
    public abstract class ICUDashboardWebViewPageBase : ICUDashboardWebViewPageBase<dynamic>
    {

    }

    public abstract class ICUDashboardWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ICUDashboardWebViewPageBase()
        {
            LocalizationSourceName = ICUDashboardConsts.LocalizationSourceName;
        }
    }
}