namespace Collectively.Messages.Commands.Mailing
{
    public class SendRemarkStateChangedEmailMessage : SendRemarkEmailMessageBase
    {
        public string State { get; set; }
    }
}