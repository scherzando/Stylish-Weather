﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UnknownBackend.Controllers
{
    public class ClothingController : ApiController
    {
        // GET: api/Clothing
        public RequestResult Get()
        {
            return new RequestResult();
        }

        // GET: api/ClothingController/5
        public RequestResult Get(string city)
        {
            return new RequestResult(city);
        }

        // POST: api/ClothingController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ClothingController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClothingController/5
        public void Delete(int id)
        {
        }
    }
}
