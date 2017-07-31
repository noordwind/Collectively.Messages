using System;

namespace Collectively.Messages.Events.Groups
{
    public class OrganizationCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }

        protected OrganizationCreated()
        {
        }

        public OrganizationCreated(Guid requestId, string userId,
            Guid organizationId)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
        }
    }
}