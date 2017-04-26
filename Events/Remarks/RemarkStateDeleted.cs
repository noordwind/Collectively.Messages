using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkStateDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid CommentId { get; }

        protected RemarkStateDeleted()
        {
        }

        public RemarkStateDeleted(Guid requestId, 
            string userId, Guid remarkId, Guid commentId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            CommentId = commentId;
        }
    }
}