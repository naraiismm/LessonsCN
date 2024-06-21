using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class StudentManagerAbstract
    {
        internal abstract void Add();
        internal void Update()
        {
            Console.WriteLine("update olundu");
        }
    }
}
