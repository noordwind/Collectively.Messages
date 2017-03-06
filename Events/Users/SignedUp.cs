using System;

namespace Collectively.Messages.Events.Users
{
    public class SignedUp : IEvent, IResource
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }

        protected SignedUp()
        {
        }

        public SignedUp(Guid requestId, Resource resource, string userId)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
        }
    }
}