using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkCreated : RemarkStateChangedBase
    {
        protected RemarkCreated()
        {
        }

        public RemarkCreated(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}