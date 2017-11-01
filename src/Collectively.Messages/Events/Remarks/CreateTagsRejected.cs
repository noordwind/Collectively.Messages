using System;

namespace Collectively.Messages.Events.Remarks
{
    public class CreateTagsRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected CreateTagsRejected()
        {
        }

        public CreateTagsRejected(Guid requestId, 
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}