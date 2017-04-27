using Abp.Application.Services;
using Blargo.JudisList.Tenants.Dashboard.Dto;

namespace Blargo.JudisList.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
