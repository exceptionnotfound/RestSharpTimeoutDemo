using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RestSharpTimeoutDemo.MVC
{
    public static class Constants
    {
        public static readonly string BaseApiUrl = ConfigurationManager.AppSettings["BaseApiUrl"];
    }
}