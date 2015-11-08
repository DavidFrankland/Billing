using System;

namespace Billing.Service.Models
{
    public class BillDto
    {
        public StatementDto Statement { get; set; }
        public decimal Total { get; set; }
        public PackageDto Package { get; set; }
        public CallChargesDto CallCharges { get; set; }
        public SkyStoreDto SkyStore { get; set; }
    }
}
