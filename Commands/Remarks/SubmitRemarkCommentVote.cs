using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class SubmitRemarkCommentVote : IAuthenticatedCommand
    {
        public Guid RemarkId { get; set; }
        public Guid CommentId { get; set; }
        public Request Request { get; set; }
        public string UserId { get; set; }
        public bool Positive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}