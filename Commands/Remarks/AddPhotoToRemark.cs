using System;

namespace Collectively.Messages.Commands.Remarks
{
    public class AddPhotoToRemark : IFileUploadCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid RemarkId { get; set; }
        public string Name { get; set; }
        public string FileBase64 { get; set; }
    }
}