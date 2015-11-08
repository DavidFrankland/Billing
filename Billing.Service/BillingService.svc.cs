using System;
using Billing.Api.Interfaces;
using Billing.Service.Interfaces;
using Billing.Service.Models;
using Billing.Service.Mapper;

namespace Billing.Service
{
    public class BillingService : IBillingService
    {
        private readonly IBillingApi _billingApi;

        public BillingService(IBillingApi billingApi)
        {
            _billingApi = billingApi;
        }

        public BillDto GetBill()
        {
            return _billingApi.GetBill().ToDto();
        }
    }
}
