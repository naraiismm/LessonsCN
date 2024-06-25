using MarketProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal interface IProductManager
    {
        void AddProduct(Product product,List<Product>products);
        void RemoveProduct(Product product, List<Product> products);
        void Update(int id, Product updatedProduct, List<Product> products);

    }
}
