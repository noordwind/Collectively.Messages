using System;
using System.Collections.Generic;

namespace Collectively.Messages.Events.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<TranslatedTag> Translations { get; set; }
    }
}