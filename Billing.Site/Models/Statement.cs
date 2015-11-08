using System;

namespace Billing.Site.Models
{
    public class Statement
    {
        public DateTime Generated { get; set; }
        public DateTime Due { get; set; }
        public Period Period { get; set; }
    }
}