using System.Collections.Generic;
using System.IO;

namespace Collectively.Messages.Commands.Remarks
{
    public class AddPhotoToRemark : IAuthenticatedCommand, IFileUploadCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public Stream File { get; set; }
    }
}