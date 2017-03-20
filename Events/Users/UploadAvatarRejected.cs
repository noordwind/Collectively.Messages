using System;

namespace Collectively.Messages.Events.Users
{
    public class UploadAvatarRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }


        protected UploadAvatarRejected()
        {
            
        }

        public UploadAvatarRejected(Guid requestId, 
            string userId, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}