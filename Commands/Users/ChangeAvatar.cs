using Collectively.Messages.Commands;

namespace Collectively.Messages.Commands.Users
{
    public class ChangeAvatar : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public string PictureUrl { get; set; }
    }
}