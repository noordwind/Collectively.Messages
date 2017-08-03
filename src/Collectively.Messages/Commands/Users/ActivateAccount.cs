namespace Collectively.Messages.Commands.Users
{
    public class ActivateAccount : ICommand
    {
        public Request Request { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}