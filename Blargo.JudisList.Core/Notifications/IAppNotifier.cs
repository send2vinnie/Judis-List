using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Blargo.JudisList.Authorization.Users;
using Blargo.JudisList.MultiTenancy;

namespace Blargo.JudisList.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
