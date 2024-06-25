using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class Users :BaseEntity
    {
        
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Majority { get; set; }


    }
}
