using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkCommentVoteDeleted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid CommentId { get; }

        protected RemarkCommentVoteDeleted()
        {
        }

        public RemarkCommentVoteDeleted(Guid requestId, string userId,
            Guid remarkId, Guid commentId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            CommentId = commentId;
        }
    }
}