using System;
using System.ComponentModel;

namespace Billing.Site.Models
{
    public class Subscription
    {
        public enum SubscriptionType
        {
            [Description("TV")]
            Tv,

            [Description("Talk")]
            Talk,

            [Description("Broadband")]
            Broadband
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
