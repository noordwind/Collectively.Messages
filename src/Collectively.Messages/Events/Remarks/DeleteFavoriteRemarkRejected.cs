using System;

namespace Collectively.Messages.Events.Remarks
{
    public class DeleteFavoriteRemarkRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected DeleteFavoriteRemarkRejected()
        {
        }

        public DeleteFavoriteRemarkRejected(Guid requestId, 
            Guid remarkId, string userId, 
            string code, string reason)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
            Code = code;
            Reason = reason;
        }
    }
}