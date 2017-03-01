using System;
using Collectively.Messages.Events;

namespace Collectively.Messages.Events.Users
{
    public class AvatarChanged : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get;}
        public string PictureUrl { get; }

        protected AvatarChanged()
        {
        }

        public AvatarChanged(Guid requestId, string userId, string pictureUrl)
        {
            RequestId = requestId;
            UserId = userId;
            PictureUrl = pictureUrl;
        }
    }
}