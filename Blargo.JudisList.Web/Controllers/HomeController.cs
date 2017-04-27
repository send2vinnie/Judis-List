using System.Web.Mvc;

namespace Blargo.JudisList.Web.Controllers
{
    public class HomeController : JudisListControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}