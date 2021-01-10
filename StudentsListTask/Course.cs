using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsListTask
{
    public class Course
    {
        public string Name { get; set; }

        public string Description { get; set; }

        private List<Student> _students;
               
        public List<Student> Students {
            get
            {
                return _students;
            }
        }

        public int overallQuantityReturn;

        public void OverallQuantityReturn()
        {
            Console.WriteLine($"Overall quantity of students: {_students.Count}");
            Console.ReadKey();
        }


        public Course(string courseName)
        {
            this.Name = courseName;
            this._students = new List<Student>();
        }


        public void AddStudent(Student item)
        {
            _students.Add(item);
            Console.WriteLine(item);
            Console.ReadKey();
        }

        public void PrintCourseStudents()
        {
            foreach (Student i in _students)
            {
                Console.WriteLine("List of students on the course:");
                Console.WriteLine(i.Name);
            }

        }

        public void QuantityCourseStudents()
        {
            Console.WriteLine($"Quantity of the students on the course: {Students.Count}");
            Console.ReadKey();

        }

    }
}
