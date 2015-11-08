using System;

namespace Billing.Site.Models
{
    public class Bill
    {
        public Statement Statement { get; set; }
        public decimal Total { get; set; }
        public Package Package { get; set; }
        public CallCharges CallCharges { get; set; }
        public SkyStore SkyStore { get; set; }
    }
}
