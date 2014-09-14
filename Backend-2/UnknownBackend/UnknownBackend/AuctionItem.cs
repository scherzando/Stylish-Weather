using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class AuctionItem
    {
        //private TrademeAccessor.QueryResult queryResult;
        public string title { get; set; }
        public string price { get; set; }
        public string itemUrl { get; set; }
        public string imageUrl { get; set; }

        public AuctionItem()
        {

        }
        
        public AuctionItem(string title, string price, string url)
        {
            // TODO: Complete member initialization
            this.title = title;
            this.price = price;
            this.itemUrl = url;
        }

        public AuctionItem(TrademeAccessor.QueryResult queryResult)
        {
            // TODO: Complete member initialization
            title = queryResult.Title;
            price = queryResult.Price;
            itemUrl = queryResult.HyperlinkUrl;
            imageUrl = queryResult.ImageUrl;
            // TODO: is image URL required???
        }
       
    }
}
