using System;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class Programme
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cost")]
        public decimal Cost { get; set; }
    }
}
