using System;
using Billing.Api.Interfaces;
using Billing.Api.Models;

namespace Billing.Api.Requests
{
    public class Bills : Core
    {
        public Bills(IWebRequestHelper webRequestHelper) : base(webRequestHelper) { }

        public Bill GetBill()
        {
            return GenericGet<Bill>("bill.json");
        }
    }
}
