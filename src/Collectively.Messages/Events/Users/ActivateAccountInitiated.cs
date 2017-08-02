using System;

namespace Collectively.Messages.Events.Users
{
    public class ActivateAccountInitiated : IEvent
    {
        public Guid RequestId { get; }
        public string Email { get; set; }

        protected ActivateAccountInitiated()
        {
        }

        public ActivateAccountInitiated(Guid requestId, string email)
        {
            RequestId = requestId;
            Email = email;
        }
    }
}