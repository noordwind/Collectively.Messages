using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RenewRemarkRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected RenewRemarkRejected()
        {
        }

        public RenewRemarkRejected(Guid requestId, 
            string userId, Guid remarkId,
            string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            Code = code;
            Reason = reason;
        }
    }
}