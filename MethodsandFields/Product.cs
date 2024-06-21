using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal class Product
    {

        public Product(int id,string productName,double unitPrice) 
        {
            Id = id;
            ProductName = productName;
            UnitPrice = unitPrice;
            Console.WriteLine($"Id:{id},name:{productName},price:{unitPrice}");
        }
        //OVERLOADING---eyni adda bir methodunn muxtelif hallarda istifadesi
        public Product(int id, string productName = "yoxdur")
        {
            productName = productName;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

    }
}
