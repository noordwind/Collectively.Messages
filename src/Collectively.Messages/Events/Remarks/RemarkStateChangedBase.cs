using System;

namespace Collectively.Messages.Events.Remarks
{
    public abstract class RemarkStateChangedBase : IAuthenticatedEvent, IResource
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid? GroupId { get; set; }


        protected RemarkStateChangedBase()
        {
        }

        public RemarkStateChangedBase(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            RemarkId = remarkId;
            GroupId = groupId;
        }
    }
}