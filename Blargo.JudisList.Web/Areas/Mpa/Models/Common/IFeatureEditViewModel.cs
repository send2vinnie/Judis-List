using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Editions.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}