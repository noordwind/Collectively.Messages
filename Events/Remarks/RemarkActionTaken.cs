using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkActionTaken : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public string Description { get; }

        protected RemarkActionTaken()
        {
        }

        public RemarkActionTaken(Guid requestId, string userId,
            Guid remarkId, string description)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            Description = description;
        }
    }
}