using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnknownBackend;

namespace UnknownBackend.Controllers
{
    /// <summary>
    /// Provides a Web API to request the current conditions.
    /// </summary>
    public class DayInfoController : ApiController
    {
        // GET api/DayInfo/
        /// <summary>
        /// GET the current weather conditions for the Wellington region. Also includes the current date.
        /// </summary>
        /// <returns>Day Information</returns>
        public DayInfo Get()
        {
            string location = "Wellington";
            WeatherAccessor accessor = new WeatherAccessor();
            return accessor.GetDayInfo(location);
        }
        /// <summary>
        /// GET the current weather conditions for a given region. Also includes the current date.
        /// </summary>
        /// <param name="location">The region to get the weather conditions for.</param>
        /// <returns>Day Information</returns>
        public DayInfo Get(string location)
        {
            WeatherAccessor accessor = new WeatherAccessor();
            return accessor.GetDayInfo(location);
        }
    }
}