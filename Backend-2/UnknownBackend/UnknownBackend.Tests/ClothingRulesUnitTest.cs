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
            ClothingOption option = rules.GetClothingTempCatigory(tempC);
            Assert.IsNotNull(option);
            Assert.AreEqual(ClothingCatigory.cold, option.Tops);

            tempC = 25;
            ClothingOption option2 = rules.GetClothingTempCatigory(tempC);
            Assert.IsNotNull(option2);
            Assert.AreEqual(ClothingCatigory.warm, option2.Tops);
        }

        [TestMethod]
        public void TestCreateClothingCatigory()
        {
            DayInfo weather1 = new DayInfo() { temp = "14", desc = "fine" };

            var option = rules.GetClothingCatigory(weather1);
            Assert.AreEqual(ClothingCatigory.cold, option.TempRange);
            WeatherCondition condition = option.WeatherType;
            Assert.AreEqual(WeatherCondition.fine, condition);

            DayInfo weather2 = new DayInfo() { temp = "14", desc = "rainy" };

            option = rules.GetClothingCatigory(weather2);
            Assert.AreEqual(ClothingCatigory.cold, option.TempRange);
            condition = option.WeatherType;
            Assert.AreEqual(WeatherCondition.rain, condition);

            DayInfo weather3 = new DayInfo() { temp = "18", desc = "windy" };

            option = rules.GetClothingCatigory(weather3);
            Assert.AreEqual(ClothingCatigory.warm, option.TempRange);
            condition = option.WeatherType;
            Assert.AreEqual(WeatherCondition.wind, condition);

            DayInfo weather4 = new DayInfo() { temp = "18", desc = "overcast" };

            option = rules.GetClothingCatigory(weather4);
            Assert.AreEqual(ClothingCatigory.warm, option.TempRange);
            condition = option.WeatherType;
            Assert.AreEqual(WeatherCondition.overcast, condition);
        }

        [TestMethod]
        public void TestCreateClothingCatigoryWithPhases()
        {
            DayInfo weather1 = new DayInfo() { temp = "18", desc = "It will be overcast" };

            var option = rules.GetClothingCatigory(weather1);
            var condition = option.WeatherType;
            Assert.AreEqual(WeatherCondition.overcast, condition);

            DayInfo weather2 = new DayInfo() { temp = "18", desc = "But will it be Fine?" };

            option = rules.GetClothingCatigory(weather2);
            condition = option.WeatherType;
            Assert.AreEqual(WeatherCondition.fine, condition);
        }
    }
}
