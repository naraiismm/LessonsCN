using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonManager
    {
        public void FullNameControllStudent(Student name)
        {
            if (name.FullName.Length> 5) 
            {
                Console.WriteLine($"{name} elave olundu");
            }
        }
        public void FullNameControllTeacher(Teacher name)
        {
            if (name.FullName.Length > 5)
            {
                Console.WriteLine($"{name} elave olundu");
            }
        }


    }
}
