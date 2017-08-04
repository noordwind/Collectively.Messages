namespace Collectively.Messages.Commands.Mailing
{
    public class SendActivateAccountEmailMessage : SendSecuredEmailMessageBase
    {
        public string Username { get; set; }
    }
}