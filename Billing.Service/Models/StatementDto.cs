using System;

namespace Billing.Service.Models
{
    public class StatementDto 
    {
        public DateTime Generated { get; set; }
        public DateTime Due { get; set; }
        public PeriodDto Period { get; set; }
    }
}