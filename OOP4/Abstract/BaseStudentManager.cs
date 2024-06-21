using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstract
{
    internal abstract class BaseStudentManager : IStudentService
    {
        public virtual void Add(Student student)
        {
            Console.WriteLine($"{student.FullName} elave olundu");
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
