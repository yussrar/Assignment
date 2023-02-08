using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class HostingCostController : ApiController
    {
        //This method will take days from user, convert days into fortnights. Calculate cost and tax and return output in double
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public double HostingCost(int id)
        {
            // creating a double variable to hold the value of amount 
            double amount = 5.50;
            //converting days into fortnights by dividing by 14 and adding 1 so we know that its the first forenight or second and so on
            //so we can calculate the cost
            int forenights =1+ (id/14);
            //calculating total by multiplying number of forenights with amount
            double total = amount * forenights;
            //calculating tax 
            double tax =  total * .13;
            //addind total and tax 
            double subtotal = total + tax;
            //returning the value
            return subtotal;
        }
    }
}
