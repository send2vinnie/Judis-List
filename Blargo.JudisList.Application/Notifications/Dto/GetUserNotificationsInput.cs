using Abp.Notifications;
using Blargo.JudisList.Dto;

namespace Blargo.JudisList.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}