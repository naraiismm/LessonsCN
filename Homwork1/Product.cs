using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double UnitPrice { get; set; }
        public bool IsDelivery { get; set; }
        public double DeliveryPrice { get; set; }
        public bool IsDiscount { get; set; }
        public double DiscountPrice { get; set; }
        
    }
}
