using System;
using Billing.Api.Interfaces;
using Billing.Api.Models;
using Billing.Api.Requests;

namespace Billing.Api
{
    public class BillingApi : IBillingApi
    {
        private readonly Bills _bills;

        public BillingApi(IWebRequestHelper webRequestHelper)
        {
            _bills = new Bills(webRequestHelper);
        }

        public Bill GetBill()
        {
            return _bills.GetBill();
        }
    }
}
