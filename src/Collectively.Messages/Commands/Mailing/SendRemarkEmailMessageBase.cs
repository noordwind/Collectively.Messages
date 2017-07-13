using System;

namespace Collectively.Messages.Commands.Mailing
{
    public abstract class SendRemarkEmailMessageBase : SendEmailMessageBase
    {
        public Guid RemarkId { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Culture { get; set; }
        public string RemarkUrl { get; set; }
    }
}