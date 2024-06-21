using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpinheritance
{
    internal class Teacher :Person
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        
        public string EducateField { get; set;}

    }
}
