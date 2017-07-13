using System;

namespace Collectively.Messages.Events.Users
{
    public class AvatarRemoved : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get;}

        protected AvatarRemoved()
        {
        }

        public AvatarRemoved(Guid requestId, string userId)
        {
            RequestId = requestId;
            UserId = userId;
        }
    }
}