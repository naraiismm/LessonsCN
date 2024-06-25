using MethodsandFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class CashierManager : ProductManager, IGets
    {
        public void GetAll(List<Product> products)
        {
            foreach (var productShow in products)
            {
                Console.WriteLine($"{productShow.Id}  {productShow.ProductName}  {productShow.UnitPrice}  ");
            }
        }

        public void GetByCatagory(int catagoryId, List<Product> products)
        {
            foreach (Product item in products)
            {
                if (item.Id == catagoryId)
                {
                    Console.WriteLine($"{item.Id}   {item.ProductName}  {item.UnitPrice}  ");
                }
            }
        }

        public Product GetById(int id, List<Product> products)
        {
            foreach (var item in products)
            {
                if (item.Id == id)
                {
                    Console.WriteLine($"{item.ProductName}  {item.UnitPrice}  ");
                }

            }
            return null;
        }
        public void ReturnTheSellingProduct(List<Product> sellingList,List<Product>products) 
        {
            foreach(var item in sellingList)
            {
                products.Add(item);
            }
        }
    }
}
