using System;

namespace Collectively.Messages.Events.Remarks
{
    public class FavoriteRemarkAdded : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected FavoriteRemarkAdded()
        {
        }

        public FavoriteRemarkAdded(Guid requestId, string userId,
            Guid remarkId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}