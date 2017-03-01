using System;
using Collectively.Messages.Commands;

namespace Collectively.Messages.Commands.Users
{
    public class RefreshUserSession : ICommand
    {
        public Request Request { get; set; }
        public Guid SessionId { get; set; }
        public Guid NewSessionId { get; set; }
        public string Key { get; set; }
    }
}