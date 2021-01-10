using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsListTask2
{
    public class Course
    {
        public string Name { get; set; }

        public string Description { get; set; }

        private List<Student> _students;

        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }

        public Course(string courseName)
        {
            this.Name = courseName;
            this._students = new List<Student>();
        }


        public void AddStudent(Student item)
        {
            _students.Add(item);
        }

    }
}
