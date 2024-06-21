using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class AndroidUser :ILogin,IUser
    {
        public void Register() 
        {
            Console.WriteLine("Android register Succesfully");
        }
        public void Login() 
        {
            Console.WriteLine("Yo log in succesfully");
        }

    }
}
