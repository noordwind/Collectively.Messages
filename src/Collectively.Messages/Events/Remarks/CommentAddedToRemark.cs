using System;

namespace Collectively.Messages.Events.Remarks
{
    public class CommentAddedToRemark : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Username { get; }
        public Guid RemarkId { get; }
        public Guid CommentId { get; }
        public string Text { get; }
        public DateTime CreatedAt { get; }

        protected CommentAddedToRemark()
        {
        }

        public CommentAddedToRemark(Guid requestId, string userId,
            string username, Guid remarkId, Guid commentId, string text,
            DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            Username = username;
            RemarkId = remarkId;
            CommentId = commentId;
            Text = text;
            CreatedAt = createdAt;
        }
    }
}