using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class EditRemarkComment : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid RemarkId { get; set; }
        public Guid CommentId { get; set; }
        public string Text { get; set; }
    }
}