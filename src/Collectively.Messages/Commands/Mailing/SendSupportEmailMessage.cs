namespace Collectively.Messages.Commands.Mailing
{
    public class SendSupportEmailMessage : SendEmailMessageBase
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}