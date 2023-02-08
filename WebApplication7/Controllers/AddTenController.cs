using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplication7.Controllers
{
    public class AddTenController : ApiController
    {
        //this method will take a value in integer from user, add 10 and return the output in integer
        // if userinput is 13, output = 23

        [HttpGet]
        [Route("api/AddTen/{x}")]
        public int AddTen(int x)
        {
            int value = 10;
            int output = x + value;
            return output;
        }
    }
}
