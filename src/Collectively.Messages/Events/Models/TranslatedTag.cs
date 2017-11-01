using System;

namespace Collectively.Messages.Events.Models
{
    public class TranslatedTag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }         
    }
}