namespace Collectively.Messages.Commands.Mailing
{
    public class SendCommentAddedToRemarkEmailMessage : SendRemarkEmailMessageBase
    {
        public string Comment { get; set; }
    }
}