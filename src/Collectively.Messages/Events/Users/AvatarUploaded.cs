using System;

namespace Collectively.Messages.Events.Users
{
    public class AvatarUploaded : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get;}
        public string AvatarUrl { get; }

        protected AvatarUploaded()
        {
        }

        public AvatarUploaded(Guid requestId, string userId, string avatarUrl)
        {
            RequestId = requestId;
            UserId = userId;
            AvatarUrl = avatarUrl;
        }
    }
}