using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class AdminManager
    {
        public bool AdminLogin(Admin admin)

        {
            Admin adminBase = new()
            {
                Id = 1,
                FullName="Mrad Musali",
                Username="admin",
                Password="admin123"
            };
            if (admin.Username == adminBase.Username&& admin.Password==adminBase.Password)
            {
                return true;
            }
            else
            {

                Console.WriteLine("Username or paswword is incorrect");
                return false;
            }


        }
        public void AddSeller(Seller seller)
        {
            Console.WriteLine($"{seller.Name} has been succesfully created");
            
        }
        public void AddMedicine(Products product)
        {
            Console.WriteLine($"{product.ProductName} has been succesfulley added");
        }   
        public void RemoveMedicine(Products products)
        {
            Console.WriteLine($"{products.ProductName} has been  succesfully removed.\nPrice:{products.Price}");
        }
    }
}
