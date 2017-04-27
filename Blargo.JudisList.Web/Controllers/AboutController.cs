using System.Web.Mvc;

namespace Blargo.JudisList.Web.Controllers
{
    public class AboutController : JudisListControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}