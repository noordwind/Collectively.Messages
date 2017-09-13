using System;
using System.Collections.Generic;
using Collectively.Messages.Commands.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class CreateRemark : ChangeRemarkStateBase
    {
        public Guid? GroupId { get; set; }
        public string Category { get; set; }
        public Offering Offering { get; set; }
        public IList<string> Tags { get; set; }
        public IList<SocialMedia> SocialMedia { get; set; }
    }
}