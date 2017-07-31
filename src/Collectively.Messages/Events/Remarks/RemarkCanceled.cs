using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkCanceled : RemarkStateChangedBase
    {
        protected RemarkCanceled()
        {
        }

        public RemarkCanceled(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}