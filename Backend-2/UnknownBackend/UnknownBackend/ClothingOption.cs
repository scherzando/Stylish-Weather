using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class ClothingOption
    {
        public ClothingCatigory Tops { get; set; }

        public ClothingCatigory Pants { get; set; }

        public ClothingCatigory Shoes { get; set; }

        public void SetAll(ClothingCatigory cat1)
        {
            Shoes = cat1;
            Pants = cat1;
            Tops = cat1;
            TempRange = cat1;
        }

        public ClothingCatigory TempRange { get; set; }

        public WeatherCondition WeatherType { get; set; }
    }
}
