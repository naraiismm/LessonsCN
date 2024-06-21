using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class StudentManager
    {
        public void AddStudent (Student student)
        {
            Console.WriteLine($"{student.FullName} elave olundu");
        }

    }
}
