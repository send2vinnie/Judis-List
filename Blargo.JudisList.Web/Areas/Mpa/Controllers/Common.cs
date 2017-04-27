using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Blargo.JudisList.Web.Areas.Mpa.Models.Common.Modals;
using Blargo.JudisList.Web.Controllers;

namespace Blargo.JudisList.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : JudisListControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}