using System;

namespace Collectively.Messages.Events.Groups
{
    public class MemberAddedToOrganization : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public string MemberId { get; }
        public string Role { get; }

        protected MemberAddedToOrganization()
        {
        }

        public MemberAddedToOrganization(Guid requestId, Resource resource,
            string userId, Guid organizationId, string memberId, string role)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            OrganizationId = organizationId;
            MemberId = memberId;
            Role = role;
        }
    }
}