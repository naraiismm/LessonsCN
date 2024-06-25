using MarketProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal interface IGets
    {
        public void GetAll(List<Product> products);
        public Product GetById(int id, List<Product> products);
        public void GetByCatagory(int id, List<Product> products);
    }
}
