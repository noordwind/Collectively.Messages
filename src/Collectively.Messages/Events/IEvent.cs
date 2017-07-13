using System;

namespace Collectively.Messages.Events
{
    public interface IEvent
    {
        Guid RequestId { get; }
    }
}