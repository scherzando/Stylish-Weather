using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class RequestResult
    {
        public string city { get; set; }

        public DayInfo weather { get; set; }
        public List<CatigoryItemGroup> items { get; set; }

        public RequestResult()
            : this("Wellington")
        {
            
        }

        public RequestResult(string city)
        {
            // TODO: Complete member initialization
            this.city = city;
            items = new List<CatigoryItemGroup>();

            WeatherAccessor accessor = new WeatherAccessor();
            weather = accessor.GetDayInfo(city);
            ClothingRules rules = new ClothingRules();
            var clothingTempRange = rules.GetClothingCatigory(weather.getTempCAsInt());
            items = TrademeAccessor.getLists(clothingTempRange);
        }
    }
}
