using System.Web.Mvc;
using Abp.Auditing;

namespace Blargo.JudisList.Web.Controllers
{
    public class ErrorController : JudisListControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}