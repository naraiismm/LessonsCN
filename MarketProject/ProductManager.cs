using MethodsandFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    public class ProductManager:IProductManager
    {
       
        public void AddProduct(Product product, List<Product> products)
        {
            
            products.Add(product);
        }

        public void RemoveProduct(Product product,List<Product>products)
        {
            products.Remove(product);   
        }

        public void Update(int id,Product updatedProduct,List<Product>products)
        {
            foreach(var item in products)
            {
                if(item.Id == id) 
                
                {
                    item.ProductName= updatedProduct.ProductName;
                    item.UnitPrice= updatedProduct.UnitPrice;
                   
                }
            }
        }
    }
}
