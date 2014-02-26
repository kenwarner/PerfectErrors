using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace PerfectErrors.Controllers
{
	public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext context)
		{
			context.Response = context.Request.CreateErrorResponse(HttpStatusCode.OK, new HttpError(context.Exception, context.Request.IsLocal()));
			base.OnException(context);
		}
	}

}