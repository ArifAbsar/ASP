﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("api/chanku/getname")]
        public HttpResponseMessage GetAllPerson()
        {
            string[] names = { "Tanvir", "Sabbir", "Rahim", "Karim" };
            return Request.CreateResponse(HttpStatusCode.OK, names);
        }
    }
}
