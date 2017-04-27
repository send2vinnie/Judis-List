using System.Collections.Generic;
using Blargo.JudisList.Authorization.Users.Dto;
using Blargo.JudisList.Dto;

namespace Blargo.JudisList.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}