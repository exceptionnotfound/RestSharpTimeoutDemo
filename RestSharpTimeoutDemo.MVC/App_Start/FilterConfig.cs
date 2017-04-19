using System.Web;
using System.Web.Mvc;

namespace RestSharpTimeoutDemo.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
