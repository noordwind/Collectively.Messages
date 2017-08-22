using System;

namespace Collectively.Messages.Events.Remarks
{
    public class ReportSent : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid ResourceId { get; }
        public string Type { get; set; }  
        public DateTime CreatedAt { get; }

        protected ReportSent()
        {
        }

        public ReportSent(Guid requestId, string userId,
            Guid resourceId, string type, DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            ResourceId = resourceId;
            Type = type;
            CreatedAt = createdAt;            
        }
    }
}