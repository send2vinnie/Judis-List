using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Blargo.JudisList.Authorization;
using Blargo.JudisList.ClassTypes;
using Blargo.JudisList.ClassTypes.Dto;
using Blargo.JudisList.Web.Areas.Mpa.Models.ClassTypes;
using Blargo.JudisList.Web.Controllers;

namespace Blargo.JudisList.Web.Areas.Mpa.Controllers
{
    public class ClassTypesController : ClassTypesControllerBase
    {
        private readonly IClassTypesAppService _classTypeAppService;

        public ClassTypesController(IClassTypesAppService classTypeAppService)
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