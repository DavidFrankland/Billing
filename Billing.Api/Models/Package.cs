using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class Package
    {
        [JsonProperty("subscriptions")]
        public List<Subscription> Subscriptions { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }
    }
}
