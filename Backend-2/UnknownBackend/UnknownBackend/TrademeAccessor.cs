using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace UnknownBackend
{
    public class TrademeAccessor
    {
        public class SearchResults
        {
            public List<Listing> List { get; set; }
        }

        public class Listing
        {
            public int ListingId { get; set; }

            public String Title { get; set; }

            public String PictureHref { get; set; }

            public String PriceDisplay { get; set; }
        }

        public class QueryResult
        {
            public string HyperlinkUrl { get; set; }

            public string Title { get; set; }

            public string ImageUrl { get; set; }

            public string Price { get; set; }
        }

        public static List<QueryResult> callTrademeApi(int catID)
        {
            WebClient client = new WebClient();
            String s = client.DownloadString(String.Format("https://api.trademe.co.nz/v1/Search/General.json?buy=All&category={0}&condition=All&expired=false&page=1&pay=All&photo_size=Gallery&return_metadata=false&shipping_method=All&sort_order=Default", catID));

            var serializer = new Newtonsoft.Json.JsonSerializer();

            var results = (SearchResults)serializer.Deserialize(new StringReader(s), typeof(SearchResults));
            var queryResults = new List<QueryResult>();

            foreach (Listing l in results.List)
            {
                var result = new QueryResult();
                result.Title = l.Title;
                result.Price = l.PriceDisplay;
                result.HyperlinkUrl = string.Format("http://www.trademe.co.nz/{0}", l.ListingId);
                result.ImageUrl = l.PictureHref;
                queryResults.Add(result);
            }
            return queryResults;
        }
    }
}
