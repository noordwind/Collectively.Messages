using System;

namespace Collectively.Messages.Events.Groups
{
    public class AddMemberToOrganizationRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public string MemberId { get; }
        public string Role { get; }
        public string Code { get; }
        public string Reason { get; }

        protected AddMemberToOrganizationRejected()
        {
        }

        public AddMemberToOrganizationRejected(Guid requestId, 
            string userId, Guid organizationId, string memberId,
            string role, string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            MemberId = memberId;
            Role = role;
            Code = code;
            Reason = reason;
        }        
    }
}