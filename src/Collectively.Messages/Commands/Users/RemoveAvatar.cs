namespace Collectively.Messages.Commands.Users
{
    public class RemoveAvatar : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
    }
}