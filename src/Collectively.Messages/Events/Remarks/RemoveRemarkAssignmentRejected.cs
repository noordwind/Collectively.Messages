using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemoveRemarkAssignmentRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }
        public Guid RemarkId { get; }
        public string Assignee { get; }

        protected RemoveRemarkAssignmentRejected()
        {
        }

        public RemoveRemarkAssignmentRejected(Guid requestId, 
            string userId, string code, string reason,
            Guid remarkId, string assignee)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
            RemarkId = remarkId;
            Assignee = assignee;
        }
    }
}