using System;

namespace Collectively.Messages.Events.Users
{
    public class UnlockAccountRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Reason { get; }
        public string Code { get; }
        public string UnlockUserId { get; }

        protected UnlockAccountRejected()
        {
        }

        public UnlockAccountRejected(Guid requestId, string userId, 
            string reason, string code, string unlockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            Reason = reason;
            Code = code;
            UnlockUserId = unlockUserId;
        }
    }
}