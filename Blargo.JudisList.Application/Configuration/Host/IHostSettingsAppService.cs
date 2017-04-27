using System.Threading.Tasks;
using Abp.Application.Services;
using Blargo.JudisList.Configuration.Host.Dto;

namespace Blargo.JudisList.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
