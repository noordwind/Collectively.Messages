namespace Collectively.Messages.Commands.Mailing
{
    public class SendSecuredEmailMessageBase : SendEmailMessageBase
    {
        public string Token { get; set; }
        public string Endpoint { get; set; }
    }
}