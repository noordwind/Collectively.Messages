using System.Collections.Generic;
using System.IO;

namespace Collectively.Messages.Commands
{
    public interface IFileUploadCommand : ICommand
    {
        string Title { get; set; }
        string Description { get; set; }
        IEnumerable<string> Tags { get; set; }
        Stream File { get; set; }
    }
}