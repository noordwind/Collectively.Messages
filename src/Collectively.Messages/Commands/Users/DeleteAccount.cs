namespace Collectively.Messages.Commands.Users
{
    public class DeleteAccount : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public bool Soft { get; set; }
    }
}