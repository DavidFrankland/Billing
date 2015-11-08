using System;

namespace Billing.Service.Models
{
    public class SubscriptionDto
    {
        public enum SubscriptionType
        {
            Tv,
            Talk,
            Broadband
        }

        public SubscriptionType Type { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
