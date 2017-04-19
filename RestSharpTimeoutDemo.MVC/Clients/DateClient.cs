using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RestSharpTimeoutDemo.MVC.Clients
{
    public class DateClient : ClientBase, IRestClient
    {
        public DateClient() : base(Constants.BaseApiUrl) { }

        public DateTime? GetDate()
        {
            var request = new RestRequest("/home/date");
            request.Timeout = 50;
            return Execute<DateTime?>(request).Data;
        }

        public async Task<DateTime?> GetDateAsync()
        {
            var request = new RestRequest("/home/date");
            request.Timeout = 50;
            var result = await ExecuteTaskAsync<DateTime?>(request);
            return result.Data;
        }
    }
}