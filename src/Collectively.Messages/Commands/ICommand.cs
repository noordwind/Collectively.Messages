namespace Collectively.Messages.Commands
{
    public interface ICommand
    {
        Request Request { get; set; }
    }
}