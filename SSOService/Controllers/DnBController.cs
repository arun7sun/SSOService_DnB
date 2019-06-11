using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
//using Microsoft.IdentityModel.Clients.ActiveDirectory;
//using System.Net.Http;
using System.Web.Mvc.Filters;

namespace SSOService.Controllers
{
    public class DnBController : ApiController
    {
        // GET: api/DnB
        public IEnumerable<string> Get()
        {
            var headers = HttpContext.Current.Request.Headers;
            //string authority = "https://rcchn0103.rctest.com/adfs";
            //string resourceURI = "https://localhost:44319/SSOService/";
            //string clientID = "3321d52f-c5e5-41c7-bb47-78f0df809b3a";
            //string clientReturnURI = "http://anarbitraryreturnuri/";

            //var authContext = new AuthenticationContext(authority, false);
            //var authResult = await authContext.AcquireTokenAsync(resourceURI, clientID, new Uri(clientReturnURI), new PlatformParameters(PromptBehavior.Auto));

            //string authHeader = authResult.CreateAuthorizationHeader();
            

            //if (headers != null)
            //{

            //}
            return new string[] { "value1", "value2" };
        }

        //private GetADFSAuth()
        //{
        //    var ac = new AuthenticationContext(authority, false);

        //    //This seems to be working as I am getting a token back after successful authentication
        //    var ar = await ac.AcquireTokenAsync(resourceURI, clientID, new Uri(clientReturnURI), new PlatformParameters(PromptBehavior.Auto));
        //    string authHeader = ar.CreateAuthorizationHeader();
        //}

        // GET: api/DnB/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DnB
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DnB/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DnB/5
        public void Delete(int id)
        {
        }
    }
}
