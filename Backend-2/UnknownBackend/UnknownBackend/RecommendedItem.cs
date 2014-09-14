using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnknownBackend
{
    public class RecommendedItem
    {
        public string Photo { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public RecommendedItem()
        {
            Photo = "http:this.will.be.a.direct.link";
            Price = "12";
            Link = "Item link";
            Description = "Sample description";
        }
    }
}