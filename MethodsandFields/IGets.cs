using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandFields
{
    internal interface IGets
    {
        public void GetAll();
        public void GetById();
        public void GetByCatagory(string name);
    }
}
