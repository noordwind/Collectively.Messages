using System;

namespace Collectively.Messages.Events.Users
{
    public class AccountLocked : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string LockUserId { get; set; }

        protected AccountLocked()
        {
        }

        public AccountLocked(Guid requestId, string userId, string lockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            LockUserId = lockUserId;
        }
    }
}