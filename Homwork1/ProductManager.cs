using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class ProductManager

    {
        public void ShowProduct(Product product)
        {
            Console.WriteLine($"ID:{product.Id}\nName:{product.ProductName}\nPrice:{product.UnitPrice}\nUrl:{product.ImgUrl}\nDelivery:{product.IsDelivery}\n Discount:{product.IsDiscount} "); 
        }

       
    }
}
 