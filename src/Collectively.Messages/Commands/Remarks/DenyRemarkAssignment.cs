using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class DenyRemarkAssignment : ChangeRemarkStateBase
    {
        public Guid? GroupId { get; set; }
    }
}