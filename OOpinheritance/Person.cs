using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpinheritance
{
    internal class Person
    {
        public Person()
        {
            IsMarreied = false;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public short Age { get; set; }
        //kim ki persondan miras alir ancaq o istifade ede biler protectedi
        protected bool IsMarreied {  get; set; }

    }
}
