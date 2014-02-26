using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace PerfectErrors.Controllers
{
	public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext context)
		{
			context.Response = new HttpResponseMessage()
			{
				StatusCode = HttpStatusCode.InternalServerError,
				ReasonPhrase = context.Exception.Message
			};
		}
	}

}