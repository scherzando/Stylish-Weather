using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnknownBackend
{
    public class ClothingRules
    {
        public ClothingOption GetClothingCatigory(int tempC)
        {
            var options = new ClothingOption();
            if (tempC < 15)
            {
                options.SetAll(ClothingCatigory.cold);
            }
            else
            {
                options.SetAll(ClothingCatigory.warm);
            }
            return options;
        }
    }
}
