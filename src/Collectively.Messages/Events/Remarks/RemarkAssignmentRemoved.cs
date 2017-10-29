using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkAssignmentRemoved : RemarkStateChangedBase
    {
        public string Assignee { get; }

        protected RemarkAssignmentRemoved()
        {
        }

        public RemarkAssignmentRemoved(Guid requestId, Resource resource, 
            string userId, Guid remarkId, string assignee)
            : base(requestId, resource, userId, remarkId, null)
        {
            Assignee = assignee;
        }
    }
}