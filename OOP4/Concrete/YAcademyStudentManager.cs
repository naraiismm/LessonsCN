using OOP4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Concrete
{
    internal class YAcademyStudentManager  : BaseStudentManager
    {
        public override void Add(Student student)
        {
            if (student.Birthday.Year<2006) { base.Add(student); }
            else
            {
                Console.WriteLine("Yas heddi uygun deyil ");
            }

        }
    }
}
