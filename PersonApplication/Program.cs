using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Person object
            Student student = new Student();
            student.FirstName = "Teppo";
            student.LastName = "Terava";
            student.Address = "Piippukatu 3";
            student.Age = 25;
            student.PhoneNumber = "040 55050150";
            student.StudentID = "K2341";
            Console.WriteLine(student.ToString());

            // create a one Teacher Object
            Teacher teacher = new Teacher();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Address = "piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D100";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            // olio ei ole aliluokan sisalla...
            

        }
    }
}
