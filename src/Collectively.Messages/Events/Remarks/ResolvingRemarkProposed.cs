using System;

namespace Collectively.Messages.Events.Remarks
{
    public class ResolvingRemarkProposed : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }

        protected ResolvingRemarkProposed()
        {
        }

        public ResolvingRemarkProposed(Guid requestId, 
            Guid remarkId, string userId)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
        }
    }
}