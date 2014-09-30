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
            temp = "20";
            desc = "Fine";
            img = "na";
            date = String.Format("{0:yyyy-MM-dd}", DateTime.Today);
            //city = "Wellington";
        }
        public DayInfo(string[] input, string city)
        {
            // TODO: Complete member initialization
            temp = input[0];
            desc = input[1];
            img = input[2];
            date = String.Format("{0:yyyy-MM-dd}", DateTime.Today);
            this.city = city.ToUpper();
            //this.input = input;
        }
        // [JsonProperty("temp")]
        public string temp { get; set; }

        // [JsonProperty("desc")]
        public string desc { get; set; }
        // [JsonProperty("img")]
        public string img { get; set; }
        public string date { get; set; }
        public string city { get; set; }

        public int getTempCAsInt()
        {
            int tempCNum;
            if (Int32.TryParse(temp, out tempCNum))
            {
                return tempCNum;
            }
            else
            {
                try
                {
                    throw (new InvalidCastException("Number could not be parsed"));
                }
                catch (InvalidCastException e)
                {
                    // give e to raygun.
                    throw;
                }
                return 20;
            }
        }
    }
}
