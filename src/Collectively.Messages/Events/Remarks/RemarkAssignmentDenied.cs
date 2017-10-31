using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkAssignmentDenied : RemarkStateChangedBase
    {
        protected RemarkAssignmentDenied()
        {
        }

        public RemarkAssignmentDenied(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}