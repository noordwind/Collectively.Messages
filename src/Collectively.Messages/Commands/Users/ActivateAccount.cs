namespace Collectively.Messages.Commands.Users
{
    public class ActivateAccount : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}