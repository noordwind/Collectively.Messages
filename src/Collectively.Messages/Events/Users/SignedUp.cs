using System;

namespace Collectively.Messages.Events.Users
{
    public class SignedUp : IEvent, IResource
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public string Provider { get; }
        public string Role { get; }
        public string State { get; }

        protected SignedUp()
        {
        }

        public SignedUp(Guid requestId, Resource resource, 
            string userId, string provider, 
            string role, string state)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            Provider = provider;
            Role = role;
            State = state;
        }
    }
}