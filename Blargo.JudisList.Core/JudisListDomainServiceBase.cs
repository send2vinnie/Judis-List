using Abp.Domain.Services;

namespace Blargo.JudisList
{
    public abstract class JudisListDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected JudisListDomainServiceBase()
        {
            LocalizationSourceName = JudisListConsts.LocalizationSourceName;
        }
    }
}
