using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfectErrors.Controllers
{
    public class ErrorController : Controller
    {
		[Route("Error/{code?}")]
		public ActionResult Error(int code = 500)
		{
			Response.StatusCode = code;
			return View();
		}
	}
}