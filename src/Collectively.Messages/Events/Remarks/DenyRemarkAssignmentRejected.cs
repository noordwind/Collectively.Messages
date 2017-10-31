using System;

namespace Collectively.Messages.Events.Remarks
{
    public class DenyRemarkAssignmentRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public Guid RemarkId { get; }
        public Guid? GroupId { get; }

        protected DenyRemarkAssignmentRejected()
        {
        }

        public DenyRemarkAssignmentRejected(Guid requestId, 
            string userId, string code, string reason,
            Guid remarkId, Guid? groupId)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            RemarkId = remarkId;
            GroupId = groupId;
        }
    }
}