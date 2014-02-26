using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PerfectErrors.Controllers
{
	public class FiveHundredApiController : ApiController
	{
		// GET api/<controller>
		[Route("api/500")]
		public IEnumerable<string> Get()
		{
			throw new Exception("throw 500 api");
		}
	}
}