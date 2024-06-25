using MethodsandFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class SellerManager :Gets
    {
        
        public void Selling(Product sellingProduct,List<Product>products,List<Product>sellingList)
        {
            sellingList.Add(sellingProduct);
            products.Remove(sellingProduct);

        }
    }
}
