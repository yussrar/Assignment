using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class NumberMachineController : ApiController
    {
        //This method takes a number from user, apply a math expression on it and return the value in int
        // if userinput = 1, output = 98
        [HttpGet]
        [Route("api/NumberMachine/{number}")]
        public int NumberMachine(int number)
        {
            int output = number/2 * 2 +100 -2;
            return output;
        }
    }
}
