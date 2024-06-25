using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal interface IProductManager
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void Update(Product product);

    }
}
