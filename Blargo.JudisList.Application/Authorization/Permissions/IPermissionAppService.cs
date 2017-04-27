using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Authorization.Permissions.Dto;

namespace Blargo.JudisList.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
