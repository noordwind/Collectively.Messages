using System.Collections.Generic;

namespace Collectively.Messages.Commands
{
    public interface IFileUploadCommand : IAuthenticatedCommand
    {
        string Title { get; set; }
        string Description { get; set; }
        IEnumerable<string> Tags { get; set; }
        string FileBase64 { get; set; }
    }
}