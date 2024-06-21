using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine($"Adi {product.ProductName} olan mehsul bazaya elave olundu");
        }

        /// <summary>
        /// eyni adda metodun basqa versiyonda istifade edilmesi
        /// </summary>
        
    }
}
