using System;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class Call
    {
        [JsonProperty("called")]
        public string Called { get; set; }

        [JsonProperty("duration")]
        public TimeSpan Duration { get; set; }

        [JsonProperty("cost")]
        public decimal Cost { get; set; }
    }
}
