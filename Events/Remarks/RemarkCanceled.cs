using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkCanceled : RemarkStateChangedBase
    {
        protected RemarkCanceled()
        {
        }

        public RemarkCanceled(Guid requestId, Resource resource, 
            string userId, Guid remarkId)
            : base(requestId, resource, userId, remarkId)
        {
        }
    }
}