using System;

namespace Collectively.Messages.Events.Remarks
{
    public class DeleteRemarkCommentVoteRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public Guid CommentId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected DeleteRemarkCommentVoteRejected()
        {
        }

        public DeleteRemarkCommentVoteRejected(Guid requestId, 
            Guid remarkId, Guid commentId, string userId, 
            string code, string reason)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            CommentId = commentId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}