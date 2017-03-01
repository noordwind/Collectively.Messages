using Collectively.Messages.Commands.Remarks.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class ResolveRemark : ChangeRemarkStateBase
    {
        public RemarkFile Photo { get; set; }
        public bool ValidatePhoto { get; set; }
        public bool ValidateLocation { get; set; }
    }
}