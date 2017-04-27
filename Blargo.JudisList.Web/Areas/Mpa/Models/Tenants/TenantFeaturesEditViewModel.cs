using Abp.AutoMapper;
using Blargo.JudisList.MultiTenancy;
using Blargo.JudisList.MultiTenancy.Dto;
using Blargo.JudisList.Web.Areas.Mpa.Models.Common;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}