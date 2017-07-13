using Collectively.Messages.Commands.Models;

namespace Collectively.Messages.Commands.Users
{
    public class UploadAvatar : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public File Avatar { get; set; }
    }
}