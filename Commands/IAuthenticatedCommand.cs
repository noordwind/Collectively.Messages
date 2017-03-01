namespace Collectively.Messages.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        string UserId { get; set; }
    }
}