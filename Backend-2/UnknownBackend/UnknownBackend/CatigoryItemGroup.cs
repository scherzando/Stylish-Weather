using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class CatigoryItemGroup
    {
        private List<TrademeAccessor.QueryResult> qItems;

       // private TrademeAccessor.QueryResult item;

        //public List<AuctionItem> items {get; set;}
        public AuctionItem first { get; set; }
        public AuctionItem second { get; set; }
        public string name { get; set; }

        public string CatUrl { get; set; }

        public CatigoryItemGroup()
        {
            //items = new List<AuctionItem>();
            first = new AuctionItem("title 1", "12", "http://www.stuff.co.nz");
            second = new AuctionItem("title 2", "12", "http://www.stuff.co.nz");
            name = "Some name";
            CatUrl = "URL";
        }

        public CatigoryItemGroup(TrademeAccessor.QueryResult item)
        {
            // TODO: Complete member initialization
            //first = item;
        }

        public CatigoryItemGroup(string name, List<TrademeAccessor.QueryResult> qItems)
        {
            // TODO: fix assume
            first = new AuctionItem(qItems[0]);
            second = new AuctionItem(qItems[1]);
            this.name = name;
        }


        public void AddItem(AuctionItem auctionItem)
        {
            first = auctionItem;
        }

        public AuctionItem GetFirstItem()
        {
            return first;
        }

      
    }
}
