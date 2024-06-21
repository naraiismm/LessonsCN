using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP4.Abstract;

namespace OOP4
{
    internal class Student : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }

    }
}
