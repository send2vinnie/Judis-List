using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Configuration.Tenants.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}