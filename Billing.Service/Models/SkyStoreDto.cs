using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class SkyStoreDto
    {
        public List<ProgrammeDto> Rentals { get; set; }
        public List<ProgrammeDto> BuyAndKeep { get; set; }
        public decimal Total { get; set; }
    }
}
