using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class CatigoryItemGroupUnitTest
    {
        CatigoryItemGroup group;
        [TestInitialize]
        public void Init()
        {
            group = new CatigoryItemGroup();
        }
        
        [TestMethod]
        public void TestGetItem1()
        {
            var item1 = new AuctionItem("title", "12", "http://www.stuff.co.nz");
            group.AddItem(item1);
            AuctionItem item = group.GetFirstItem();
            Assert.AreEqual(item, item);
        }

        [TestMethod]
        public void TestSetName()
        {
            group.name = "Name";
            Assert.AreEqual("Name", group.name);
        }

        [TestMethod]
        public void TestSetCatUrl()
        {
            group.CatUrl = "URL";
            Assert.AreEqual("URL", group.CatUrl);
        }
    }
}
