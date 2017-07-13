using System;

namespace Collectively.Messages.Events.Users
{
    public class UsernameChanged : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string NewName { get; }
        public string State { get; }

        protected UsernameChanged()
        {
        }

        public UsernameChanged(Guid requestId, string userId, string newName, string state)
        {
            RequestId = requestId;
            UserId = userId;
            NewName = newName;
            State = state;
        }
    }
}