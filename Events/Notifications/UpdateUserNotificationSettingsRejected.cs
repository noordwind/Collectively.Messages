using System;

namespace Collectively.Messages.Events.Notifications
{
    public class UpdateUserNotificationSettingsRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }
        public string Reason { get; }
        public string Code { get; }

        protected UpdateUserNotificationSettingsRejected()
        {
            
        }

        public UpdateUserNotificationSettingsRejected(Guid requestId,
            Guid remarkId, string userId,
            string code, string reason)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}