using System;

namespace Collectively.Messages.Events.Users
{
    public class AccountUnlocked : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string UnlockUserId { get; set; }

        protected AccountUnlocked()
        {
        }

        public AccountUnlocked(Guid requestId, string userId, string unlockUserId)
        {
            RequestId = requestId;
            UserId = userId;
            UnlockUserId = unlockUserId;
        }
    }
}