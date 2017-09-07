using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRouting.Controllers
{
    public class RoutingController : ApiController
    {   
        [HttpGet]
        public string display(int id)
        {  
                string str = "Athira";
                return str;
           
        }
        [HttpPost]
        public void taking(int id)
        {
            int para = id;
        }
        [HttpGet]
        public string cleat(string str1)
        {
            string str = "Athira1";
            return str;

        }

    }
}
