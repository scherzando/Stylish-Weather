using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnknownBackend;

namespace UnknownBackend.Tests
{
    [TestClass]
    public class AuctionItemUnitTest
    {
        AuctionItem item;
        [TestInitialize]
        public void Init()
        {
            item = new AuctionItem();
        }

        [TestMethod]
        public void TestParamConstruct()
        {
            var item2 = new AuctionItem("title", "12", "http://www.stuff.co.nz");
        }
        
        [TestMethod]
        public void TestSetTitle()
        {
            var title = "title";
            item.title = title;
            Assert.AreEqual(title, item.title);
        }

        [TestMethod]
        public void TestSetPrice()
        {
            var price = "10";
            item.price = price;
            Assert.AreEqual(price, item.price);
        }

        [TestMethod]
        public void TestSetItemUrl()
        {
            var itemUrl = "http://www.stuff.co.nz";
            item.itemUrl = itemUrl;
            Assert.AreEqual(itemUrl, item.itemUrl);
        }

        [TestMethod]
        public void TestSetImageUrl()
        {
            var imageUrl = "http://www.stuff.png";
            item.imageUrl = imageUrl;
            Assert.AreEqual(imageUrl, item.imageUrl);
        }

        
    }
}
