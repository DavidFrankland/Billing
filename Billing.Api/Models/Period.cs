using System;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class Period
    {
        [JsonProperty("from")]
        public DateTime From { get; set; }

        [JsonProperty("to")]
        public DateTime To { get; set; }
    }
}