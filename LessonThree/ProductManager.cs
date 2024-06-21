using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    internal class ProductManager
    {
        public void AddProduct() { Console.WriteLine(); }

        public void ProductAddtoCart(Product product) { Console.WriteLine($"sebete {product.ProductName} adli mehsul elave olundu qiymeti {product.UnitPrice}"); }


        public void GetProduct(Product product)
        {
            Console.WriteLine($"{product.ProductName}  xusuiyeti:{product.Description} , qiymeti {product.UnitPrice}");
        }
        public void GetCart(Product product)
        {
            Console.WriteLine($"{product.ProductName}  xusuiyeti:{product.Description} , qiymeti {product.UnitPrice}");
        }
    }
}
