using System;
using Collectively.Messages.Events;

namespace Collectively.Messages.Events.Operations
{
    public class OperationUpdated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Name { get; }
        public string State { get; }
        public string Code { get; }
        public string Message { get; }
        public DateTime UpdatedAt { get; }

        protected OperationUpdated()
        {
        }

        public OperationUpdated(Guid requestId,
            string userId, string name, 
            string state,string code, 
            string message, DateTime updatedAt)
        {
            RequestId = requestId;
            UserId = userId;
            Name = name;
            State = state;
            Code = code;
            Message = message;
            UpdatedAt = updatedAt;
        }
    }
}