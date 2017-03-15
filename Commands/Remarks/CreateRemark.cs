using System.Collections.Generic;
using Collectively.Messages.Commands.Remarks.Models;

namespace Collectively.Messages.Commands.Remarks
{
    public class CreateRemark : ChangeRemarkStateBase
    {
        public string Category { get; set; }
        public RemarkFile Photo { get; set; }
        public IList<string> Tags { get; set; }
        public IList<SocialMedia> SocialMedia { get; set; }
    }
}