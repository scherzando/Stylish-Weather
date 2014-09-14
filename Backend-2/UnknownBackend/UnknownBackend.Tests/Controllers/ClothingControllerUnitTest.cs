using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend.Controllers;

namespace UnknownBackend.Tests.Controllers
{
    [TestClass]
    public class ClothingControllerUnitTest
    {
        ClothingController controller;
        
        [TestMethod]
        public void TestGETClothing()
        {
            controller = new ClothingController();

            var result= controller.Get();

            Assert.IsNotNull(result);
        }
    }
}
