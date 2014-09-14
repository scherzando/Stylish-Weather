using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class RequestResult
    {
        public DayInfo weather { get; set; }
        public List<CatigoryItemGroup> items { get; set; }

        public RequestResult()
        {
            items = new List<CatigoryItemGroup>();
            
            WeatherAccessor accessor = new WeatherAccessor();
            weather = accessor.GetDayInfo();
            var qItems = TrademeAccessor.callTrademeApi(3051);
            items.Add(new CatigoryItemGroup("Skirts", qItems));
            //foreach (var item in qItems)
            //    items.Add(new CatigoryItemGroup(item));
     
        }
    }
}
