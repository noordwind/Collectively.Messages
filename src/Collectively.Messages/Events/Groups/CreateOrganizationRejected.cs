using System;

namespace Collectively.Messages.Events.Groups
{
    public class CreateOrganizationRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid OrganizationId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected CreateOrganizationRejected()
        {
        }

        public CreateOrganizationRejected(Guid requestId, 
            string userId, Guid organizationId,
            string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            OrganizationId = organizationId;
            Code = code;
            Reason = reason;
        }
    }
}