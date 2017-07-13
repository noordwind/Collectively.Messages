using System;

namespace Collectively.Messages.Events.Remarks
{
    public class FavoriteRemarkDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected FavoriteRemarkDeleted()
        {
        }

        public FavoriteRemarkDeleted(Guid requestId, string userId,
            Guid remarkId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}