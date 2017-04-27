using Abp.AutoMapper;
using Blargo.JudisList.Authorization.Roles.Dto;
using Blargo.JudisList.Web.Areas.Mpa.Models.Common;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}