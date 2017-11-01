using System.Collections.Generic;

namespace Collectively.Messages.Commands.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public IEnumerable<TranslatedTag> Translations { get; set; }
    }
}