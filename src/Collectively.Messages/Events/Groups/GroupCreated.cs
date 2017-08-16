using System;

namespace Collectively.Messages.Events.Groups
{
    public class GroupCreated : IAuthenticatedEvent, IResource
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public Guid GroupId { get; }
        public Guid? OrganizationId { get; }

        protected GroupCreated()
        {
        }

        public GroupCreated(Guid requestId, Resource resource,
            string userId, Guid groupId, Guid? organizationId = null)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            GroupId = groupId;
            OrganizationId = organizationId;
        }
    }
}