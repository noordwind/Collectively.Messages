using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class SendReport : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid ResourceId { get; set; }
        public string Type { get; set; }        
    }
}