using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnknownBackend
{
    /// TODO: use the weather description to diside the category, and the temp to deside the style.
    /// 1. detemine the right category
    /// 2. detemine the right style
    /// 2e. the styles are dependent on the categories.
    public abstract class CategorySearchGenerator
    {
        public abstract string GetSearch(ClothingOption weatherConditions);

        public static CategorySearchGenerator Create(string searchword)
        {
            if (searchword.Equals("Pants")) return new PantsGenerator();
            if (searchword.Equals("Tops")) return new TopGenerator();
            if (searchword.Equals("Shoes")) return new FootwareGenerator();
            else throw new NotImplementedException("No such searchword defined.");
        }
    }
    // _________________________________________________________________________
    public class TopGenerator : CategorySearchGenerator
    {
        public override string GetSearch(ClothingOption weatherConditions)
        {
            if (weatherConditions.TempRange == ClothingCatigory.cold && 
               (weatherConditions.WeatherType == WeatherCondition.overcast) || 
                weatherConditions.WeatherType == WeatherCondition.wind)
            {
                return "category=3033&style=jumpers&jerseys&cardigan";
            }
            else if (weatherConditions.TempRange == ClothingCatigory.cold &&
                    (weatherConditions.WeatherType == WeatherCondition.rain ||
                     weatherConditions.WeatherType == WeatherCondition.overcast))
            {
                return "category=3033&style=jumpers&jerseys&cardigan";
                // what to were when cold and and fine.
            }
            else if (weatherConditions.TempRange == ClothingCatigory.warm &&
                    (weatherConditions.WeatherType == WeatherCondition.fine ||
                     weatherConditions.WeatherType == WeatherCondition.overcast))
            {
                return "category=3033&style=short sleeve&t-shirt";
            }
            else
            {
                return "category=3033&style=short sleeve&t-shirt";
            }
        }
    }

    // _________________________________________________________________________
    public class PantsGenerator : CategorySearchGenerator
    {
        public override string GetSearch(ClothingOption weatherConditions)
        {
            if (weatherConditions.TempRange == ClothingCatigory.cold)
            {
                return "category=6849&style=jeans&pants";
            }
            else
            {
                return "category=6849&style=shorts&pants";
            }
        }
    }
    // _________________________________________________________________________
    public class FootwareGenerator : CategorySearchGenerator
    {
        public override string GetSearch(ClothingOption weatherConditions)
        {
            if (weatherConditions.TempRange == ClothingCatigory.cold)
            {
                return "category=762&style=Boots";
            }
            else
            {
                return "category=762&style=sandals&jandals";
            }
        }
    }
}