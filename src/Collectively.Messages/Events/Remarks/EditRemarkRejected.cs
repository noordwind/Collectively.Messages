using System;

namespace Collectively.Messages.Events.Remarks
{
    public class EditRemarkRejected : IRejectedEvent, IEditable
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected EditRemarkRejected()
        {
        }

        public EditRemarkRejected(Guid requestId, 
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