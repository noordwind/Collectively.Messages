using System;
using System.Collections.Generic;
using Collectively.Messages.Events.Remarks.Models;
using Collectively.Messages.Events;

namespace Collectively.Messages.Events.Remarks
{
    public class PhotosToRemarkAdded : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public Guid RemarkId { get; }
        public string UserId { get; }
        public IEnumerable<RemarkFile> Photos { get; }

        protected PhotosToRemarkAdded()
        {
        }

        public PhotosToRemarkAdded(Guid requestId, Guid remarkId, 
            string userId, IEnumerable<RemarkFile> photos)
        {
            RequestId = requestId;
            RemarkId = remarkId;
            UserId = userId;
            Photos = photos;
        }
    }
}