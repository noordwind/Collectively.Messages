namespace Collectively.Messages.Commands.Users
{
    public class ChangeUsername : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
    }
}