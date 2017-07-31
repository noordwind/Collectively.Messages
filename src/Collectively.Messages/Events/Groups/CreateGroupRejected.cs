using System;

namespace Collectively.Messages.Events.Groups
{
    public class CreateGroupRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid GroupId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected CreateGroupRejected()
        {
        }

        public CreateGroupRejected(Guid requestId, 
            string userId, Guid groupId,
            string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            GroupId = groupId;
            Code = code;
            Reason = reason;
        }
    }
}