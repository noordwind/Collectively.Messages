namespace Collectively.Messages.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        string UserId { get; }
    }
}