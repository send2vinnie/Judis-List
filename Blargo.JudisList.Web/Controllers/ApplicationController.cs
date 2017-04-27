using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;

namespace Blargo.JudisList.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ApplicationController : JudisListControllerBase
    {
        [DisableAuditing]
        public ActionResult Index()
        {
            /* Enable next line to redirect to Multi-Page Application */
            /* return RedirectToAction("Index", "Home", new {area = "Mpa"}); */

return RedirectToAction("Index", "Home", new {area = "Mpa"});
        }
    }
}
