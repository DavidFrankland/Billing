using System;
using System.Collections.Generic;

namespace Billing.Site.Models
{
    public class SkyStore
    {
        public List<Programme> Rentals { get; set; }
        public List<Programme> BuyAndKeep { get; set; }
        public decimal Total { get; set; }
    }
}
