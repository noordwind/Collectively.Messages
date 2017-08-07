namespace Collectively.Messages.Commands.Users
{
    public class LockAccount : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string LockUserId { get; set; }
    }
}