using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;
using System.Collections.Generic;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class RequestResultUnitTest
    {
        RequestResult rResult;
        
        [TestInitialize]
        public void Init()
        {

            
        }
        
        [TestMethod]
        public void TestSetWeather()
        {
            // TODO
        }

        [TestMethod]
        public void TestSetItems()
        {
            rResult = new RequestResult();
            rResult.items = new List<CatigoryItemGroup>();
            Assert.IsNotNull(rResult.items);
            rResult.items.Add(new CatigoryItemGroup());
        }

        [TestMethod]
        public void TestParamCity()
        {
            rResult = new RequestResult("Wellington");
            //rResult.items = new List<CatigoryItemGroup>();
            Assert.IsNotNull(rResult.items);
            Assert.AreEqual("WELLINGTON", rResult.weather.city);

            rResult = new RequestResult("Auckland");
            //rResult.items = new List<CatigoryItemGroup>();
            Assert.IsNotNull(rResult.items);
            Assert.AreEqual("AUCKLAND", rResult.weather.city);
        }
    }
}
