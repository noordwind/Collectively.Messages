using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class ReportRemark : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid RemarkId { get; set; }
        public Guid ResourceId { get; set; }
        public string Type { get; set; }        
    }
}