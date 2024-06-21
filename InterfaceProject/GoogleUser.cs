using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class GoogleUser :IUser
    {
      public void Register() 
        {
            Console.WriteLine("Google classdan register");
        }
    }
}
