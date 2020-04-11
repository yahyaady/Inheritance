using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Yahya", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Ardi", 30, "191128", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Yanto", 19, "2818", "yahya.ardiyanto@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
