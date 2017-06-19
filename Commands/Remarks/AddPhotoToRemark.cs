using System.Collections.Generic;

namespace Collectively.Messages.Commands.Remarks
{
    public class AddPhotoToRemark : IFileUploadCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string FileBase64 { get; set; }
    }
}