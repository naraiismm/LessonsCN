using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class User :IUser
    {
        public void Register() { Console.WriteLine("User class uzerinden kayit islemi"); }
    }
}
