using System;
using System.Collections.Generic;
using Collectively.Messages.Events.Remarks.Models;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkResolved : RemarkStateChangedBase
    {
        public IEnumerable<RemarkFile> Photos { get; }

        protected RemarkResolved()
        {
        }

        public RemarkResolved(Guid requestId, Guid remarkId, 
            string userId, string username, string description, 
            RemarkLocation location, DateTime createdAt, 
            IEnumerable<RemarkFile> photos) 
            : base(requestId, remarkId, userId, username, 
                "resolved", description, location, createdAt)
        {
            Photos = photos;
        }
    }
}