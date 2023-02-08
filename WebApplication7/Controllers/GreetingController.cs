using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class GreetingController : ApiController
    {
        //This method will display a message "Hello World" in string
        [HttpGet]
        [Route("api/Greeting")]
        public string Greeting()
        {
            return "Hello World!";
        }

        //This method will take a value from user in int and return the output "Greetings to (user input) people"
        //userinput = 6 , output = Greetings to 6 people
        [HttpGet]
        [Route("api/Greeting/{id}")]

        public string Greeting(int id)
        {
            return "Greetings to " + id.ToString() + " people";
        }
    }
}
