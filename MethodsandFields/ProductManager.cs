using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal class ProductManager : IProductManager
    {

        public void AddProduct(Product product)
        {
            Console.WriteLine($"Adi {product.ProductName} olan mehsul bazaya elave olundu");
        }

        public void RemoveProduct(Product product)
        {
            Console.WriteLine($"{product.ProductName}");
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// eyni adda metodun basqa versiyonda istifade edilmesi
        /// </summary>

    }
}
