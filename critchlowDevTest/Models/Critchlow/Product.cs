using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace critchlowDevTest.Models.Critchlow
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int SortOrder { get; set; }
        public string CurrencyCode { get; set; }
    }
}