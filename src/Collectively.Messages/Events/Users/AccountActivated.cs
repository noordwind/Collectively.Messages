using System;

namespace Collectively.Messages.Events.Users
{
    public class AccountActivated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Email { get; set; }

        protected AccountActivated()
        {
        }

        public AccountActivated(Guid requestId, string email, string userId)
        {
            RequestId = requestId;
            Email = email;
            UserId = userId;
        }
    }
}