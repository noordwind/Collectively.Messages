using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkActionCanceled : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected RemarkActionCanceled()
        {
        }

        public RemarkActionCanceled(Guid requestId, string userId,
            Guid remarkId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}