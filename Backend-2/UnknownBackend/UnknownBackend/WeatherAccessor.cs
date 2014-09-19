using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace UnknownBackend
{
    public class WeatherAccessor
    {
        public DayInfo GetDayInfo(string city)
        {
            try
            {
                return new DayInfo(cleanupArray(callweatherApi(city)), city);
            }
            catch (WebException)
            {
                return new DayInfo() { city = city};
            }
        }


        public static void Main(string[] args)
        {
            String[] output = cleanupArray(callweatherApi("Wellington"));

            foreach (String w in callweatherApi("Wellington"))
            {
                Console.Write(w);
            }

            Console.ReadKey(true);

        }





        public static String[] callweatherApi(string city)
        {
            String query = @"api.worldweatheronline.com/premium/v1/weather.ashx?q=Wellington&format=json&num_of_days=1&mca=NO&fx24=NO&includelocation=NO&show_comments=NO&tp=NO&showlocaltime=NO&key=a8d4a095add9aaee2d937dcf1d85c6493adffc83";
            WebClient weather = new WebClient();
            String result = weather.DownloadString("https://api.worldweatheronline.com/premium/v1/weather.ashx?q="+city+"&format=json&num_of_days=1&mca=NO&fx24=NO&includelocation=NO&show_comments=NO&tp=NO&showlocaltime=NO&key=a8d4a095add9aaee2d937dcf1d85c6493adffc83");

            return parseWeatherapi(result);
        }



        public static string[] parseWeatherapi(String message)
        {
            String[] divide = { "temp_C\": \"", "\", \"temp_F" };
            String[] temp = message.Split(divide, StringSplitOptions.RemoveEmptyEntries);
            String[] tempvalue = new String[3];
            tempvalue[0] = temp[1];
            String[] divide2 = { "value\": \"", "\" }" };
            String[] value = temp[2].Split(divide2, StringSplitOptions.RemoveEmptyEntries);
            tempvalue[1] = value[1];
            tempvalue[2] = value[3];
            return tempvalue;
        }

        public static String[] cleanupArray(String[] input)
        {
            input[2] = input[2].Replace("\\", "");
            return input;
        }
    }
}
