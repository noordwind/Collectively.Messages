using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkAssignedToGroup : RemarkStateChangedBase
    {
        protected RemarkAssignedToGroup()
        {
        }

        public RemarkAssignedToGroup(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid groupId)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}