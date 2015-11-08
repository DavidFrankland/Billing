using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class CallCharges
    {
        [JsonProperty("calls")]
        public List<Call> Calls { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }
    }
}
