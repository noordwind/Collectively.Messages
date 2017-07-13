using Collectively.Messages.Commands;

namespace Collectively.Messages.Commands.Mailing
{
    public abstract class SendEmailMessageBase : ICommand
    {
        public Request Request { get; set; }
        public string Email { get; set; }
    }
}