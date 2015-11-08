namespace Billing.Api.Interfaces
{
    public interface IWebRequestHelper
    {
        RequestResult GetRequestResult(string requestMethod, string requestUrl);
    }
}