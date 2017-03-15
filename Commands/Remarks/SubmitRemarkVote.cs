using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class SubmitRemarkVote : IAuthenticatedCommand
    {
        public Guid RemarkId { get; set; }
        public Request Request { get; set; }
        public string UserId { get; set; }
        public bool Positive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}