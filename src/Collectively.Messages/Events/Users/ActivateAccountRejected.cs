using System;

namespace Collectively.Messages.Events.Users
{
    public class ActivateAccountRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Reason { get; }
        public string Code { get; }
        public string Email { get; }

        protected ActivateAccountRejected()
        {
            
        }

        public ActivateAccountRejected(Guid requestId,
            string email, string code, string reason, string userId = "")
        {
            RequestId = requestId;
            Email = email;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}