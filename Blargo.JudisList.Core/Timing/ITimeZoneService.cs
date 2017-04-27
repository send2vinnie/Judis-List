using System.Threading.Tasks;
using Abp.Configuration;

namespace Blargo.JudisList.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
