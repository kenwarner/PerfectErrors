using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PerfectErrors.Controllers;

namespace PerfectErrors
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
			config.Filters.Add(new CustomExceptionFilterAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
