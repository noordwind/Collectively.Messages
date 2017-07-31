using System;

namespace Collectively.Messages.Events.Groups
{
    public class OrganizationCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }

        protected OrganizationCreated()
        {
        }

        public OrganizationCreated(Guid requestId, Resource resource,
            string userId, Guid organizationId)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            OrganizationId = organizationId;
        }
    }
}