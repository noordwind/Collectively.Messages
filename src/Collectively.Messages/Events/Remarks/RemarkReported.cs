using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkReported : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid? ResourceId { get; }
        public string Type { get; set; }  

        protected RemarkReported()
        {
        }

        public RemarkReported(Guid requestId, string userId, Guid remarkId,
            Guid? resourceId, string type, DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            ResourceId = resourceId;
            Type = type;
        }
    }
}