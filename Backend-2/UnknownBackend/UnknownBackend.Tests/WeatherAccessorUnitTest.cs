using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class WeatherAccessorUnitTest
    {
        WeatherAccessor accessor;
        
        [TestInitialize]
        public void Init()
        {
            accessor = new WeatherAccessor();
            Assert.IsNotNull(accessor);
        }
        
        [TestMethod]
        public void TestGetDayInfo()
        {
            DayInfo dayInfo = accessor.GetDayInfo();
            Assert.IsNotNull(dayInfo);
        }
    }
}
