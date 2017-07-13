namespace Collectively.Messages.Commands.Remarks
{
    public class ResolveRemark : ChangeRemarkStateBase
    {
        public bool ValidatePhoto { get; set; }
        public bool ValidateLocation { get; set; }
    }
}