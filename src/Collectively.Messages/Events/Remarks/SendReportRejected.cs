using System;

namespace Collectively.Messages.Events.Remarks
{
    public class SendReportRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid ResourceId { get; }
        public string Type { get; }
        public string Code { get; }
        public string Reason { get; }

        protected SendReportRejected()
        {
        }

        public SendReportRejected(Guid requestId, 
            string userId, Guid resourceId, string type,
            string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            ResourceId = resourceId;
            Type = type;
            Code = code;
            Reason = reason;
        }
    }
}