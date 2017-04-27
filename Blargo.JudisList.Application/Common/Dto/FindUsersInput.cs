using Blargo.JudisList.Dto;

namespace Blargo.JudisList.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}