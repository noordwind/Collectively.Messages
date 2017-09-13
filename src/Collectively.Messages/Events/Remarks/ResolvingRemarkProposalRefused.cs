using System;

namespace Collectively.Messages.Events.Remarks
{
    public class ResolvingRemarkProposalRefused : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }
        public string ProposerId { get; }        

        protected ResolvingRemarkProposalRefused()
        {
        }

        public ResolvingRemarkProposalRefused(Guid requestId, 
            Guid remarkId, string userId, string proposerId)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
            ProposerId = proposerId;
        }
    }
}