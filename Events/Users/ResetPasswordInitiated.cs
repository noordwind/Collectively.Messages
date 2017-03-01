using System;
using Collectively.Messages.Events;

namespace Collectively.Messages.Events.Users
{
    public class ResetPasswordInitiated : IEvent
    {
        public Guid RequestId { get; }
        public string Email { get; }

        protected ResetPasswordInitiated()
        {
        }

        public ResetPasswordInitiated(Guid requestId, string email)
        {
            RequestId = requestId;
            Email = email;
        }
    }
}