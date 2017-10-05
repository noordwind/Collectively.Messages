using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkEdited : IAuthenticatedEvent, IEditable
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected RemarkEdited()
        {
        }

        public RemarkEdited(Guid requestId, 
            string userId, Guid remarkId)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}