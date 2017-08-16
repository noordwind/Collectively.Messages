using System;

namespace Collectively.Messages.Events.Groups
{
    public class AddMemberToGroupRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid GroupId { get; }
        public string MemberId { get; }
        public string Role { get; }
        public string Code { get; }
        public string Reason { get; }

        protected AddMemberToGroupRejected()
        {
        }

        public AddMemberToGroupRejected(Guid requestId, 
            string userId, Guid groupId, string memberId,
            string role, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            GroupId = groupId;
            MemberId = memberId;
            Role = role;
            Code = code;
            Reason = reason;
        }
    }
}