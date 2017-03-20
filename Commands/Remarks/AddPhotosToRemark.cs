using System;
using System.Collections.Generic;
using Collectively.Messages.Commands.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class AddPhotosToRemark : IAuthenticatedCommand
    {
        public Guid RemarkId { get; set; }
        public Request Request { get; set; }
        public string UserId { get; set; }
        public IList<File> Photos { get; set; }
    }
}