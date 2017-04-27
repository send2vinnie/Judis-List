using System.Threading.Tasks;
using Abp.Application.Services;
using Blargo.JudisList.Sessions.Dto;

namespace Blargo.JudisList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
