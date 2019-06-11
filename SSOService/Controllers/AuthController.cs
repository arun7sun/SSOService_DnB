using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SSOService.Controllers
{
    [Authorize]
    public class AuthController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetADFSUserAuth()
        {

            return new string[] { "value1", "value2" };
        }
    }
}
