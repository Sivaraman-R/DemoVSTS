using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoVSTS.Controllers
{
    [RoutePrefix("api/Math")]
    public class MathController : ApiController
    {
        [HttpGet]
        [Route("Add/{a}/{b}")]
        public int Add(int a, int b)
        {
            //int a = 10;
            //int b = 10;
            return a + b;
        }

        [HttpGet]
        [Route("Sub/{a}/{b}")]
        public int Sub(int a, int b)
        {
            //int a = 10;
            //int b = 10;
            return a - b;
        }

        [HttpGet]
        [Route("Mul/{a}/{b}")]
        public int Mul(int a, int b)
        {
            //int a = 10;
            //int b = 10;
            return a * b;
        }

        [HttpGet]
        [Route("Div/{a}/{b}")]
        public int Div(int a, int b)
        {
            //int a = 20;
            //int b = 10;
            return a / b;
        }
    }
}
