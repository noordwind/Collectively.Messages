using System.Collections.Generic;
using Collectively.Messages.Commands.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class CreateTags : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public IList<Tag> Tags { get; set; }        
    }
}