using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class DayInfo
    {
        //private string[] input;

        public DayInfo()
        {
            
        }
        public DayInfo(string[] input)
        {
            // TODO: Complete member initialization
            temp = input[0];
            desc = input[1];
            img = input[2];
            date = String.Format("{0:yyyy-MM-dd}", DateTime.Today);
            //this.input = input;
        }
        // [JsonProperty("temp")]
        public string temp { get; set; }

        // [JsonProperty("desc")]
        public string desc { get; set; }
        // [JsonProperty("img")]
        public string img { get; set; }
        public string date { get; set; }

        public int getTempCAsInt()
        {
            int tempCNum;
            if (Int32.TryParse(temp, out tempCNum))
            {
                return tempCNum;
            }
            else
            {
                return 20;
            }
        }
    }
}
