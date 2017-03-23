using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkCommentVoteSubmitted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid CommentId { get; }
        public bool Positive { get; }
        public DateTime CreatedAt { get; }

        protected RemarkCommentVoteSubmitted()
        {
        }

        public RemarkCommentVoteSubmitted(Guid requestId, string userId,
            Guid remarkId, Guid commentId, bool positive, DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            CommentId = commentId;
            Positive = positive;
            CreatedAt = createdAt;            
        }
    }
}