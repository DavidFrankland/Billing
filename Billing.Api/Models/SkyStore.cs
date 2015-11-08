using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class SkyStore
    {
        [JsonProperty("rentals")]
        public List<Programme> Rentals { get; set; }

        [JsonProperty("buyAndKeep")]
        public List<Programme> BuyAndKeep { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }
    }
}
