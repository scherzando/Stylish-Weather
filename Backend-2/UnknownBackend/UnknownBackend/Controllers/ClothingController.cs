using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UnknownBackend.Controllers
{
    /// <summary>
    /// Provides a Web API to request clothing suggestions.
    /// </summary>
    public class ClothingController : ApiController
    {
        // GET: api/Clothing
        /// <summary>
        /// GET clothing suggestions based of the current weather conditions in Wellington.
        /// </summary>
        /// <returns>A Request Result</returns>
        public RequestResult Get()
        {
            return new RequestResult();
        }

        // GET: api/ClothingController/?city="wellington"
        /// <summary>
        /// GET clothing suggestions based off the current weather for a given city. 
        /// </summary>
        /// <param name="city">The city to get the weather conditions for.</param>
        /// <returns>A Request Result</returns>
        public RequestResult Get(string city)
        {
            return new RequestResult(city);
        }
    }
}
