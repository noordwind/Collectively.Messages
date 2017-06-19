using System.IO;

namespace Collectively.Messages.Commands
{
    public interface IFileUploadCommand
    {
        Stream File { get; set; }
    }
}