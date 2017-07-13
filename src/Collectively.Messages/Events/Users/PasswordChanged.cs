using System;

namespace Collectively.Messages.Events.Users
{
    public class PasswordChanged : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get;}

        protected PasswordChanged()
        {
        }

        public PasswordChanged(Guid requestId, string userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}