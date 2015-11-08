using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class Subscription
    {
        public enum SubscriptionType
        {
            Tv,
            Talk,
            Broadband
        }

        [JsonProperty("type")]
        public SubscriptionType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public decimal Cost { get; set; }
    }
}
