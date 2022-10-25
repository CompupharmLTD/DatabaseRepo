using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompupharmLtd.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public string ProductSummary { get; set; }
        public string ProductRestriction { get; set; }
        public string ProductImage { get; set; }
    }
}
