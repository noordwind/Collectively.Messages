using System;
using System.Collections.Generic;
using Collectively.Messages.Commands;
using Collectively.Messages.Commands.Remarks.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class RemovePhotosFromRemark : IAuthenticatedCommand
    {
        public Guid RemarkId { get; set; }
        public Request Request { get; set; }
        public string UserId { get; set; }
        public IList<GroupedFile> Photos { get; set; }
    }
}