using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Authorization.Users.Dto;

namespace Blargo.JudisList.Authorization.Users
{
    public interface IUserLinkAppService : IApplicationService
    {
        Task LinkToUser(LinkToUserInput linkToUserInput);

        Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input);

        Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers();

        Task UnlinkUser(UnlinkUserInput input);
    }
}
