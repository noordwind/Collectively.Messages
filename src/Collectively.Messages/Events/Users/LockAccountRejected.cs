using System;

namespace Collectively.Messages.Events.Users
{
    public class LockAccountRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Reason { get; }
        public string Code { get; }
        public string LockUserId { get; }

        protected LockAccountRejected()
        {
        }

        public LockAccountRejected(Guid requestId, string userId, 
            string reason, string code, string lockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            Reason = reason;
            Code = code;
            LockUserId = lockUserId;
        }
    }
}