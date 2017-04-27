using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace Blargo.JudisList.Web.Views
{
    public abstract class JudisListWebViewPageBase : JudisListWebViewPageBase<dynamic>
    {
       
    }

    public abstract class JudisListWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected JudisListWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = JudisListConsts.LocalizationSourceName;
        }
    }
}