using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkDeleted : RemarkStateChangedBase
    {
        protected RemarkDeleted()
        {
        }

        public RemarkDeleted(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}