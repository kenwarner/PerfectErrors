using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfectErrors.Controllers
{
    public class FiveHundredController : Controller
    {
        //
        // GET: /FiveHundred/
		[Route("500")]
        public ActionResult Index()
        {
            throw new Exception("throw a 500 MVC");
        }
	}
}