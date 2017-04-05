using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkActionTaken : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Username { get; }
        public Guid RemarkId { get; }
        public string Description { get; }

        protected RemarkActionTaken()
        {
        }

        public RemarkActionTaken(Guid requestId, string userId,
            string username, Guid remarkId, string description)
        {
            RequestId = requestId;
            UserId = userId;
            Username = username;
            RemarkId = remarkId;
            Description = description;
        }
    }
}