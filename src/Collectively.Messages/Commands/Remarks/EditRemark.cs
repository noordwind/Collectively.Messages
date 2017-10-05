using System;
using System.Collections.Generic;

namespace Collectively.Messages.Commands.Remarks
{
    public class EditRemark : IAuthenticatedCommand, IEditable
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid RemarkId { get; set; }
        public string Category { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Description { get; set; }
        public Guid? GroupId { get; set; }
        public IList<string> Tags { get; set; }
    }
}