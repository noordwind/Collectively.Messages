using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkDeleted : RemarkStateChangedBase
    {
        protected RemarkDeleted()
        {
        }

        public RemarkDeleted(Guid requestId, Resource resource, 
            string userId, Guid remarkId)
            : base(requestId, resource, userId, remarkId)
        {
        }
    }
}