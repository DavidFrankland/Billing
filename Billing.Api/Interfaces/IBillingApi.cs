using Billing.Api.Models;

namespace Billing.Api.Interfaces
{
    public interface IBillingApi 
    {
        Bill GetBill();
    }
}