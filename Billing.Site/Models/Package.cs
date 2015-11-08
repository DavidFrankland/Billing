using System;
using System.Collections.Generic;

namespace Billing.Site.Models
{
    public class Package
    {
        public List<Subscription> Subscriptions { get; set; }
        public decimal Total { get; set; }
    }
}
