using System;

namespace Collectively.Messages.Events.Notifications
{
    public class UserNotificationSettingsUpdated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }

        protected UserNotificationSettingsUpdated()
        {
            
        }

        public UserNotificationSettingsUpdated(Guid requestId, string userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}