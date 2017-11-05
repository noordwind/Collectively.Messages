using System;
using System.Collections.Generic;
using System.Linq;
using Collectively.Messages.Events.Models;

namespace Collectively.Messages.Events.Remarks
{
    public class TagsCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public IEnumerable<Tag> Tags { get; }

        protected TagsCreated() 
        {
            Tags = Enumerable.Empty<Tag>();
        }

        protected TagsCreated(IEnumerable<Tag> tags) 
        {
            Tags = tags;
        }

        public TagsCreated(Guid requestId, string userId,
            IEnumerable<Tag> tags)
        {
            RequestId = requestId;
            UserId = userId;
            Tags = tags.ToList();
        }
    }
}