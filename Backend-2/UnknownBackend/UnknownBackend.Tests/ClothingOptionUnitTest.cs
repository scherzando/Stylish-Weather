using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class ClothingOptionUnitTest
    {
        ClothingOption cOptions;
        [TestInitialize]
        public void Init()
        {
            cOptions = new ClothingOption();
        }
        
        [TestMethod]
        public void TestSetTops()
        {
            ClothingCatigory cat1 = ClothingCatigory.Light;
            cOptions.Tops = cat1;
            Assert.AreEqual(cat1, cOptions.Tops);
        }

        [TestMethod]
        public void TestSetPants()
        {
            ClothingCatigory cat1 = ClothingCatigory.Light;
            cOptions.Pants = cat1;
            Assert.AreEqual(cat1, cOptions.Tops);
        }

        [TestMethod]
        public void TestSetShoes()
        {
            ClothingCatigory cat1 = ClothingCatigory.Light;
            cOptions.Shoes = cat1;
            Assert.AreEqual(cat1, cOptions.Tops);
        }

        [TestMethod]
        public void TestSetAll()
        {
            ClothingCatigory cat1 = ClothingCatigory.Heavy;
            cOptions.SetAll(cat1);
            Assert.AreEqual(cat1, cOptions.Tops);
        }
    }
}
