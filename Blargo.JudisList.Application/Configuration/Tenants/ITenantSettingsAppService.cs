using System.Threading.Tasks;
using Abp.Application.Services;
using Blargo.JudisList.Configuration.Tenants.Dto;

namespace Blargo.JudisList.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
