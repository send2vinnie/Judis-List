using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Authorization.Users.Dto;

namespace Blargo.JudisList.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
