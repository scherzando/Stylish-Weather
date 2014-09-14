using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class ParseUnitTest
    {
        [TestMethod]
        public void TestParse()
        {
            string[] s = { "", "" };

        }


        public string[] parseWeatherapi(String message)
        {
            String[] divide = { "temp_C", "temp_F" };

            string[] words = message.Split(' ');

            String[] temp = message.Split(divide, StringSplitOptions.RemoveEmptyEntries);
            return temp;

        }


    }
}
