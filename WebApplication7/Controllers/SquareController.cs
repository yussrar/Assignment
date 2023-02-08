using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class SquareController : ApiController
    {
        //This method takes a value from user in integer and return the square of the value in integer
        // if userinput = 4 , output = 16
        [HttpGet]
        [Route("api/Square/{id}")]
        public int Square(int id)
        {
            int output = id * id;
            return output;
        }
    }
}
