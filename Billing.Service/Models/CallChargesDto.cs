using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class CallChargesDto
    {
        public List<CallDto> Calls { get; set; }
        public decimal Total { get; set; }
    }
}
