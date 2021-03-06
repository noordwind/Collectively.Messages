using System;

namespace Collectively.Messages.Events.Groups
{
    public class MemberAddedToGroup : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid GroupId { get; }
        public string MemberId { get; }
        public string Role { get; }

        protected MemberAddedToGroup()
        {
        }

        public MemberAddedToGroup(Guid requestId, string userId, 
            Guid groupId, string memberId, string role)
        {
            RequestId = requestId;
            UserId = userId;
            GroupId = groupId;
            MemberId = memberId;
            Role = role;
        }
    }
}