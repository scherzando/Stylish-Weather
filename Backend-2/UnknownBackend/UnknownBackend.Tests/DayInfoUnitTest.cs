using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class DayInfoUnitTest
    {
        DayInfo dayInfo;
        
        [TestInitialize]
        public void Init()
        {
            dayInfo = new DayInfo();
        }

        [TestMethod]
        public void TestParamConstruct()
        {
            string[] input = { "15", "fine", "png" };
            dayInfo = new DayInfo(input, "Wellington");
        }

        [TestMethod]
        public void TestSetTempC()
        {
            dayInfo.temp = "15";
            Assert.AreEqual("15", dayInfo.temp);
        }

        [TestMethod]
        public void TestSetWeatherDescription()
        {
            dayInfo.desc = "Fine";
            Assert.AreEqual("Fine", dayInfo.desc);
        }

        [TestMethod]
        public void TestSetWeatherIcon()
        {
            dayInfo.img = "Icon.png";
            Assert.AreEqual("Icon.png", dayInfo.img);
        }
        [TestMethod]
        public void TestDayInfo()
        {
            dayInfo.temp = "20";
            Assert.AreEqual(20, dayInfo.getTempCAsInt());
            dayInfo.temp = "14";
            Assert.AreEqual(14, dayInfo.getTempCAsInt());
        }
    }
}
