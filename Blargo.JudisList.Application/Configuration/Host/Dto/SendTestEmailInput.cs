using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Blargo.JudisList.Authorization.Users;

namespace Blargo.JudisList.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}