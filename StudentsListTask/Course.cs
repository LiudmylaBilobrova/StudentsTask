using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsListTask
{
    class Course
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Course(string courseName)
        {
            this.Name = courseName;
        }
    }
}
