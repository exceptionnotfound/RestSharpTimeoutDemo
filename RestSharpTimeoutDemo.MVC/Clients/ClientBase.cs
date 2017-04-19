using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RestSharpTimeoutDemo.MVC.Clients
{
    public class ClientBase : RestSharp.RestClient
    {
        public ClientBase(string baseUrl)
        {
            BaseUrl = new Uri(baseUrl);
        }

        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            var response = base.Execute<T>(request);
            TimeoutCheck(request, response);
            return response;
        }

        public override async Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
        {
            var response = await base.ExecuteTaskAsync(request);
            TimeoutCheck(request, response);
            return response;
        }

        public override async Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request)
        {
            var response = await base.ExecuteTaskAsync<T>(request);
            TimeoutCheck(request, response);
            return response;
        }

        private void TimeoutCheck(IRestRequest request, IRestResponse response)
        {
            if (response.StatusCode == 0)
            {
                throw new TimeoutException("The request timed out!");
            }
        }
    }
}