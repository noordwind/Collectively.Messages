using Collectively.Messages.Commands.Models;

namespace Collectively.Messages.Commands.Notifications
{
    public class UpdateUserNotificationSettings : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Culture { get; set; }
        public NotificationSettings EmailSettings { get; set; }
        public NotificationSettings PushSettings { get; set; }
    }
}