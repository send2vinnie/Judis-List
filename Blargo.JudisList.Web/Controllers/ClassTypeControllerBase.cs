using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abp.IdentityFramework;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Microsoft.AspNet.Identity;

namespace Blargo.JudisList.Web.Controllers
{
    // <summary>
    /// Derive all Controllers from this class.
    /// Add your methods to this class common for all controllers.
    /// </summary>
    public abstract class ClassTypesControllerBase : AbpController
    {
        protected ClassTypesControllerBase()
        {
            //LocalizationSourceName = ClassTypesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}