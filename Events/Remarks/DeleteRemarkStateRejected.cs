using System;

namespace Collectively.Messages.Events.Remarks
{
    public class DeleteRemarkStateRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public Guid StateId { get; }
        public string UserId { get; }
        public string Reason { get; }
        public string Code { get; }

        public DeleteRemarkStateRejected(Guid requestId,
            Guid remarkId, Guid stateId, string userId,
            string reason, string code)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            StateId = stateId;
            UserId = userId;
            Reason = reason;
            Code = code;
        }
    }
}