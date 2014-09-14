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
            if (tempC < 20)
            {
                options.SetAll(ClothingCatigory.Heavy);
            }
            else
            {
                options.SetAll(ClothingCatigory.Light);
            }


            return options;
        }
    }
}
