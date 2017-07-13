namespace Collectively.Messages.Commands.Mailing
{
    public class SendResetPasswordEmailMessage : SendEmailMessageBase
    {
        public string Token { get; set; }
        public string Endpoint { get; set; }
    }
}