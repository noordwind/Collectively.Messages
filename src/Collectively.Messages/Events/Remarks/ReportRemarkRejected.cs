using System;

namespace Collectively.Messages.Events.Remarks
{
    public class ReportRemarkRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid ResourceId { get; }
        public string Type { get; }
        public string Code { get; }
        public string Reason { get; }

        protected ReportRemarkRejected()
        {
        }

        public ReportRemarkRejected(Guid requestId, 
            string userId, Guid remarkId, Guid resourceId, 
            string type, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            ResourceId = resourceId;
            Type = type;
            Code = code;
            Reason = reason;
        }
    }
}