using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkEdited : IAuthenticatedEvent, IEditable
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected RemarkEdited()
        {
        }

        public RemarkEdited(Guid requestId, 
            Resource resource, string userId, 
            Guid remarkId)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}