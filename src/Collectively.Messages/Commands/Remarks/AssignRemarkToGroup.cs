using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class AssignRemarkToGroup : ChangeRemarkStateBase
    {
        public Guid GroupId { get; set; }
    }
}