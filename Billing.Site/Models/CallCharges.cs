using System;
using System.Collections.Generic;

namespace Billing.Site.Models
{
    public class CallCharges
    {
        public List<Call> Calls { get; set; }
        public decimal Total { get; set; }
    }
}
