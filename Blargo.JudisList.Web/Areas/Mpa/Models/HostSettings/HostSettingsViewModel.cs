using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Configuration.Host.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}