using System;

namespace Collectively.Messages.Events.Users
{
    public class SignedUp : IEvent, IResource
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public string Provider { get; set; }

        protected SignedUp()
        {
        }

        public SignedUp(Guid requestId, Resource resource, 
            string userId, string provider)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            Provider = provider;
        }
    }
}