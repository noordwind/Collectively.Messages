using System;

namespace Collectively.Messages.Commands.Groups
{
    public class AddMemberToOrganization : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid OrganizationId { get; set; }
        public string MemberId { get; set; }
        public string Role { get; set; }
    }
}