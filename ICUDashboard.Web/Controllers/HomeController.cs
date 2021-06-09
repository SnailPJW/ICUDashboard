using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ICUDashboard.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ICUDashboardControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}