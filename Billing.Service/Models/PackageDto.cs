using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class PackageDto
    {
        public List<SubscriptionDto> Subscriptions { get; set; }
        public decimal Total { get; set; }
    }
}
