using System;

namespace Collectively.Messages.Events.Users
{
    public class AccountActivated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }

        protected AccountActivated()
        {
        }

        public AccountActivated(Guid requestId, string userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}