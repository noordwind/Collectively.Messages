using System;
using Collectively.Messages.Events.Remarks.Models;
using Collectively.Messages.Events;

namespace Collectively.Messages.Events.Remarks
{
    public abstract class RemarkStateChangedBase : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }
        public RemarkState State { get; }

        protected RemarkStateChangedBase()
        {
        }

        public RemarkStateChangedBase(Guid requestId, Guid remarkId, 
            string userId, string username, string state, 
            string description, RemarkLocation location,
            DateTime createdAt)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
            State = new RemarkState
            {
                State = state,
                UserId = userId,
                Username = username,
                Description = description,
                Location = location,
                CreatedAt = createdAt
            };
        }
    }
}