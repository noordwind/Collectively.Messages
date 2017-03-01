using System.Threading.Tasks;

namespace Collectively.Messages.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}