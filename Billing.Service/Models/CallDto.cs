using System;

namespace Billing.Service.Models
{
    public class CallDto
    {
        public string Called { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Cost { get; set; }
    }
}
