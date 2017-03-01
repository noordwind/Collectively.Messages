using System;
using Collectively.Messages.Events;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkVoteDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected RemarkVoteDeleted()
        {
        }

        public RemarkVoteDeleted(Guid requestId, string userId,
            Guid remarkId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}