using System;

namespace Collectively.Messages.Events.Remarks
{
    public class ResolvingRemarkProposalAccepted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }
        public string ProposerId { get; }        

        protected ResolvingRemarkProposalAccepted()
        {
        }

        public ResolvingRemarkProposalAccepted(Guid requestId, 
            Guid remarkId, string userId, string proposerId)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
            ProposerId = proposerId;
        }
    }
}