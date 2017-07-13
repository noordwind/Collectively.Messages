using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class TakeRemarkAction : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid RemarkId { get; set; }
        public string Description { get; set; }
    }
}