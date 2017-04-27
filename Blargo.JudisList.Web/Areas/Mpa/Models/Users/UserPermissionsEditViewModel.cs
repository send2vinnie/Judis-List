using Abp.AutoMapper;
using Blargo.JudisList.Authorization.Users;
using Blargo.JudisList.Authorization.Users.Dto;
using Blargo.JudisList.Web.Areas.Mpa.Models.Common;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}