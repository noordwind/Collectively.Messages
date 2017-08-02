using System;

namespace Collectively.Messages.Events.Users
{
    public class ActivateAccountRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Reason { get; }
        public string Code { get; }

        protected ActivateAccountRejected()
        {
            
        }

        public ActivateAccountRejected(Guid requestId,
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}