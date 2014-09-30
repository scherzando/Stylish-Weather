using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class ClothingRules
    {
        ClothingOption weatherClothing = new ClothingOption();
        public ClothingOption GetClothingTempCatigory(int tempC)
        {
            // var weatherClothing = new ClothingOption();
            if (tempC < 15)
            {
                weatherClothing.SetAll(ClothingCatigory.cold);
            }
            else
            {
                weatherClothing.SetAll(ClothingCatigory.warm);
            }
            return weatherClothing;
        }

        public ClothingOption GetClothingCatigory(DayInfo weather)
        {
            GetClothingTempCatigory(weather.getTempCAsInt());
            SetWeatherCondition(weather.desc);

            Debug.Print("TempC: " + weather.getTempCAsInt());
            return weatherClothing;
        }

        private void SetWeatherCondition(string weatherCondition)
        {
            WeatherCondition condition = WeatherCondition.fine;
            foreach (var possibleCondition in condition.GetArray())
            {
                if (weatherCondition.ToLower().Contains(possibleCondition.ToString()))
                {
                    weatherClothing.WeatherType = possibleCondition;
                    break; // do not like (I wrote it)!!!!
                }
            }
        }
    }
}
