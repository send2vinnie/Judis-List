using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Blargo.JudisList.Authorization;
using Blargo.JudisList.Web.Controllers;
using Blargo.JudisList.Web.Areas.Mpa.Models.ClassType;

namespace Blargo.JudisList.Web.Areas.Mpa.Controllers
{
    public class ClassTypesController : JudisListControllerBase
    {
        private readonly IClassTypeAppService _classTypeAppService;

        public ClassTypesController(IClassTypeAppService classTypeAppService)
        {
            _classTypeAppService = classTypeAppService;
        }

        public ActionResult Index(GetClassTypesInput input)
        {
            var output = _classTypeAppService.GetClassTypes(input);
            var model = new IndexViewModel(output);

            return View(model);
        }

        public PartialViewResult CreateClassTypeModal()
        {
            return PartialView("_CreateClassTypeModal");
        }

    }
}