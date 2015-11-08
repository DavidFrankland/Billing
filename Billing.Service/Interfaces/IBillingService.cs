using System;
using System.ServiceModel;
using Billing.Service.Models;

namespace Billing.Service.Interfaces
{
    [ServiceContract]
    public interface IBillingService
    {
        [OperationContract]
        BillDto GetBill();
    }
}
