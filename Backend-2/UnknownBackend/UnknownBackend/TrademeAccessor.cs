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

        //public static List<QueryResult> callTrademeApi(String Searhword)
        //{
        //    WebClient client = new WebClient();
        //    String s = client.DownloadString(String.Format("https://api.trademe.co.nz/v1/Search/General.json?buy=All&{0}&photo_size=Gallery", Searhword));

        //    var serializer = new Newtonsoft.Json.JsonSerializer();

        //    var results = (SearchResults)serializer.Deserialize(new StringReader(s), typeof(SearchResults));
        //    var queryResults = new List<QueryResult>();

        //    foreach (Listing l in results.List)
        //    {
        //        var result = new QueryResult();
        //        result.Title = l.Title;
        //        result.Price = l.PriceDisplay;
        //        result.HyperlinkUrl = string.Format("http://www.trademe.co.nz/{0}", l.ListingId);
        //        result.ImageUrl = l.PictureHref;
        //        queryResults.Add(result);
        //    }
        //    return queryResults;
        //}

        public static List<CatigoryItemGroup> getLists(ClothingOption clothingTempRange)
        {
            try
            {
                var AlltheLists = new List<List<QueryResult>> { };

                //    if (varWeather.Equals("OverCast ) 
                var resultsTops = callTrademeApi(CategorySort(clothingTempRange, "Tops"));
                var resultsPant = callTrademeApi(CategorySort(clothingTempRange, "Pants"));
                var resultsShoes = callTrademeApi(CategorySort(clothingTempRange, "Shoes"));

                // AlltheLists = new List<List<QueryResult>>();

                AlltheLists.Add(resultsTops);

                AlltheLists.Add(resultsPant);
                AlltheLists.Add(resultsShoes);

                List<CatigoryItemGroup> items = new List<CatigoryItemGroup>();
                items.Add(new CatigoryItemGroup("Tops for " + clothingTempRange.TempRange + " weather", resultsTops));
                items.Add(new CatigoryItemGroup("Pants for " + clothingTempRange.TempRange + " weather", resultsPant));
                items.Add(new CatigoryItemGroup("Shoes for " + clothingTempRange.TempRange + " weather", resultsShoes));
                return items;
            }
            catch(WebException)
            {
                List<CatigoryItemGroup> items = new List<CatigoryItemGroup>();
                items.Add(new CatigoryItemGroup());
                items.Add(new CatigoryItemGroup());
                items.Add(new CatigoryItemGroup());
                return items;
            }
                
                
        }
        public static List<QueryResult> callTrademeApi(String Searhword)
        {
            WebClient client = new WebClient();
            String s = client.DownloadString(String.Format("https://api.trademe.co.nz/v1/Search/General.json?buy=All&{0}&photo_size=Gallery", Searhword));
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

        public static string CategorySort(ClothingOption clothingTempRange, String searchword)
        {
            switch (clothingTempRange.TempRange)
            {
                case ClothingCatigory.warm:
                    if (searchword.Equals("Pants")) return "category=6849&style=shorts&pants";
                    if (searchword.Equals("Tops")) return "category=3033&style=short sleeve&t-shirt";
                    if (searchword.Equals("Shoes")) return "category=762&style=sandals&jandals";
                    break;
                case ClothingCatigory.cold:
                    if (searchword.Equals("Pants")) return "category=6849&style=jeans&pants";
                    if (searchword.Equals("Tops")) return "category=3033&style=jumpers&jerseys&cardigan";
                    if (searchword.Equals("Shoes")) return "category=762&style=Boots";
                    break;
                default:
                    break;
            }
            

            

            throw new Exception("Oh noes, it broke :-(");

        }



    }










}

