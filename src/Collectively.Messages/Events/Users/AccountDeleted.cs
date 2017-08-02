using System;

namespace Collectively.Messages.Events.Users
{
    public class AccountDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get;}
        public bool Soft { get; }

        protected AccountDeleted()
        {
        }

        public AccountDeleted(Guid requestId, string userId, bool soft)
        {
            RequestId = requestId;
            UserId = userId;
            Soft = soft;
        }
    }
}