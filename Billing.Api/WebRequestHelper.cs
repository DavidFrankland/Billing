using System;
using System.IO;
using System.Net;
using Billing.Api.Interfaces;

namespace Billing.Api
{
    public class WebRequestHelper : IWebRequestHelper
    {
        public RequestResult GetRequestResult(string requestMethod, string requestUrl)
        {
            var request = WebRequest.Create(requestUrl) as HttpWebRequest;

            request.Method = requestMethod;
            request.Accept = "application/json";
            request.ContentLength = 0;

            var response = request.GetResponse() as HttpWebResponse;
            
            var responseStream = response.GetResponseStream();
            
            string responseFromServer;

            using (var streamReader = new StreamReader(responseStream))
            {
                responseFromServer = streamReader.ReadToEnd();
            }

            return new RequestResult
            {
                Content = responseFromServer,
                HttpStatusCode = response.StatusCode
            };
        }
    }
}
