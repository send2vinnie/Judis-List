using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Authorization.Permissions.Dto;

namespace Blargo.JudisList.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}