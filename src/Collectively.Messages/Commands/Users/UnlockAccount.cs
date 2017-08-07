namespace Collectively.Messages.Commands.Users
{
    public class UnlockAccount : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string UnlockUserId { get; set; }
    }
}