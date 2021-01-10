using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsListTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Aristarh") { BirthDate = new DateTime(2003, 1, 1), Age = 18 };
            var student2 = new Student("Innokentiy") { BirthDate = new DateTime(2005, 12, 31), Age = 19 };
            var student3 = new Student("Edik") { BirthDate = new DateTime(2004, 7, 7), Age = 17 };
        }
    }
}
