using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Blargo.JudisList.Web.Controllers;

namespace Blargo.JudisList.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : JudisListControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}