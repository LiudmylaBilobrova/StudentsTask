using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsListTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Aristarh") { BirthDate = new DateTime(2003, 1, 1), Age = 18 };
            var student2 = new Student("Innokentiy") { BirthDate = new DateTime(2005, 12, 31), Age = 19 };
            var student3 = new Student("Edik") { BirthDate = new DateTime(2004, 7, 7), Age = 17 };

            var list = new List<Student>() {student1, student2, student3};

            Console.WriteLine($"Overall quantity of students: {list.Count}");
            Console.ReadKey();

            // Не вдалося отримати правильний результат при додаванні студентів способом нижче:
            /*list.Add(student1);
            list.Add(student2);
            list.Add(student3);*/

            // Чьот я думала, що це я викорастаю при розрахунку кількості студентів, але ніт- воно каунтом прекрасно порахувалось
            /*foreach (Student studentsQuantity in list)
            {
                Console.WriteLine(studentsQuantity);
            }
            */

            var course1 = new Course("Engineering") {Description = "for learning robotics"};
            var course2 = new Course("Cyber Security") { Description = "for learning basics of cybersecurity"};

        }
    }
}
