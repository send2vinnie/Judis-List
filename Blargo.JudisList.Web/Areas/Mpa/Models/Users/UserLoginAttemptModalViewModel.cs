using System.Collections.Generic;
using Blargo.JudisList.Authorization.Users.Dto;

namespace Blargo.JudisList.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}