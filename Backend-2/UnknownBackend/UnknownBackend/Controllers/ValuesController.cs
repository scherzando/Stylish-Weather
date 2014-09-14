using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UnknownBackend.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public RecommendedItem[] Get()
        {
            RecommendedItem[] items = { new RecommendedItem(), new RecommendedItem() };
            return items;
        }

        // GET api/values/5
        public string Get(int id)
        {
            // TODO: hard code extra information.
            string location;

            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
