using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Editions.Dto;

namespace Blargo.JudisList.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}