using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //access modifier--- private,protected,internal,public
    //internal ancaq bir namespacede olan layihlerin icersinde isleyir
    //private- ancaq bir scopun daxilinde istifade olunur
    //protected-
    internal class ProductManager
    {

        private int Id{ get; set;}
        private void Add()
        {
            Id++;
        }
    }
}
