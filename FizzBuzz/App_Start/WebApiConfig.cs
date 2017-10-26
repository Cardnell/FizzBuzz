using System.Net.Http.Headers;
using System.Web.Http;

namespace FizzBuzz
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "FizzBuzz",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/html"));
        }
    }
}