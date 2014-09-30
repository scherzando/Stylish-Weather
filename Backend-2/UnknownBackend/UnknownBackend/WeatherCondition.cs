using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public enum WeatherCondition
    {
        fine,
        rain,
        wind,
        overcast
    }

    public static class WeatherOverloads
    {
        public static WeatherCondition[] GetArray(this WeatherCondition condition)
        {
            WeatherCondition[] conditions = { WeatherCondition.fine, 
                                              WeatherCondition.rain, 
                                              WeatherCondition.wind, 
                                              WeatherCondition.overcast};
            return conditions;
        }
    }
}
