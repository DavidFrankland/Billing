using System;
using System.Net;
using Newtonsoft.Json;
using Billing.Api.Interfaces;

namespace Billing.Api.Requests
{
    public class Core
    {
        private const string API_URL = "http://safe-plains-5453.herokuapp.com/";

        private readonly IWebRequestHelper _webRequestHelper;

        protected Core(IWebRequestHelper webRequestHelper)
        {
            _webRequestHelper = webRequestHelper;
        }

        protected T GenericGet<T>(string resource)
        {
            var requestUrl = API_URL;

            if (!requestUrl.EndsWith("/"))
            {
                requestUrl += "/";
            }

            requestUrl += resource;

            try
            {
                var requestResult = _webRequestHelper.GetRequestResult("GET", requestUrl);

                return JsonConvert.DeserializeObject<T>(requestResult.Content);
            }
            catch (WebException ex)
            {
                throw new WebException(ex.Message + " " + ex.Response.Headers, ex);
            }
        }
    }
}
