using System;

namespace Collectively.Messages.Commands.Models
{
    public class Offering
    {
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}