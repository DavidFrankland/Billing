using System;

namespace Billing.Site.Models
{
    public class Call
    {
        public string Called { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Cost { get; set; }
    }
}
