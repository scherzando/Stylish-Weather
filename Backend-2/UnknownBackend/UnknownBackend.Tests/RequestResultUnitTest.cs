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

            rResult = new RequestResult();
        }
        
        [TestMethod]
        public void TestSetWeather()
        {
            // TODO
        }

        [TestMethod]
        public void TestSetItems()
        {
            rResult.items = new List<CatigoryItemGroup>();
            Assert.IsNotNull(rResult.items);
            rResult.items.Add(new CatigoryItemGroup());
        }
    }
}
