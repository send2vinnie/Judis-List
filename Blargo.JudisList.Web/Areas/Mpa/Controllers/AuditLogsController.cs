using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using Blargo.JudisList.Authorization;
using Blargo.JudisList.Web.Controllers;

namespace Blargo.JudisList.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : JudisListControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}