using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class ClothingRulesUnitTest
    {
        ClothingRules rules;
        [TestInitialize]
        public void Init()
        {
            rules = new ClothingRules();
        }

        [TestMethod]
        public void TestGetClothingCatigory()
        {
            int tempC = 10;
            ClothingOption option = rules.GetClothingCatigory(tempC);
            Assert.IsNotNull(option);
            Assert.AreEqual(ClothingCatigory.Heavy, option.Tops);

            tempC = 25;
            ClothingOption option2 = rules.GetClothingCatigory(tempC);
            Assert.IsNotNull(option2);
            Assert.AreEqual(ClothingCatigory.Light, option2.Tops);
        }
    }
}
