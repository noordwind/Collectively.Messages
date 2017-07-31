using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkRenewed : RemarkStateChangedBase
    {
        protected RemarkRenewed()
        {
        }

        public RemarkRenewed(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}