using System.Collections.Generic;
using Blargo.JudisList.Caching.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}