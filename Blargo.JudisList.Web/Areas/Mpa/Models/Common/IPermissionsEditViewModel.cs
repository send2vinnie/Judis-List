using System.Collections.Generic;
using Blargo.JudisList.Authorization.Permissions.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}