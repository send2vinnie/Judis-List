using Abp.WebApi.Controllers;

namespace Blargo.JudisList.WebApi
{
    public abstract class JudisListApiControllerBase : AbpApiController
    {
        protected JudisListApiControllerBase()
        {
            LocalizationSourceName = JudisListConsts.LocalizationSourceName;
        }
    }
}