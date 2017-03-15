using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkCreated : RemarkStateChangedBase
    {
        protected RemarkCreated()
        {
        }

        public RemarkCreated(Guid requestId, Resource resource, 
            string userId, Guid remarkId)
            : base(requestId, resource, userId, remarkId)
        {
        }
    }
}