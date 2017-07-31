using System;

namespace Collectively.Messages.Events.Groups
{
    public class GroupCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid GroupId { get; }
        public Guid? OrganizationId { get; }

        protected GroupCreated()
        {
        }

        public GroupCreated(Guid requestId, string userId,
            Guid groupId, Guid? organizationId = null)
        {
            RequestId = requestId;
            UserId = userId;
            GroupId = groupId;
            OrganizationId = organizationId;
        }
    }
}