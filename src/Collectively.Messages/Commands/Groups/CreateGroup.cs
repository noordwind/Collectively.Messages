using System;
using System.Collections.Generic;

namespace Collectively.Messages.Commands.Groups
{
    public class CreateGroup : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid GroupId { get; set; }
        public Guid? OrganizationId { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public IDictionary<string,ISet<string>> Criteria { get; set; }
    }
}