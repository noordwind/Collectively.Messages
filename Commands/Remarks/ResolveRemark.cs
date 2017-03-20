using Collectively.Messages.Commands.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class ResolveRemark : ChangeRemarkStateBase
    {
        public File Photo { get; set; }
        public bool ValidatePhoto { get; set; }
        public bool ValidateLocation { get; set; }
    }
}