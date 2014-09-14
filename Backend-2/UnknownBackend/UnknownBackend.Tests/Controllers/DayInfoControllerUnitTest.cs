using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend.Controllers;
using System.Net;

namespace UnknownBackend.Tests.Controllers
{
    [TestClass]
    public class DayInfoControllerUnitTest
    {
        [TestMethod]
        public void GETDayInfo()
        {
            DayInfoController dInfoController = new DayInfoController();

            DayInfo infoResult = dInfoController.Get();
            Assert.IsNotNull(infoResult);
            Assert.IsNotNull(infoResult.temp);
            // WebClient web;
            //web.;
        }
    }
}
