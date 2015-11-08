using System;
using Newtonsoft.Json;

namespace Billing.Api.Models
{
    public class Statement 
    {
        [JsonProperty("generated")]
        public DateTime Generated { get; set; }

        [JsonProperty("due")]
        public DateTime Due { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }
    }
}