using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Blargo.JudisList.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
