using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    internal class Product
        //foreign,primary-key ID
    {
        //entity class sqldeki classlara qarsiliq gelir,entity classdirsa anca properties saxlamalidir
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public double UnitPrice { get; set; }
        public double StockCount { get; set; }

        public bool isDelivery { get; set; }
    }
}
