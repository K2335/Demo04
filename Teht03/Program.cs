using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee keijo = new Employee();
            Boss erno = new Boss();

            keijo.Name = "Keijo Kalastaja";
            erno.Name = "Erno Palomies";

            keijo.Salary = 1300;
            erno.Salary = 3600;

            keijo.Profession = "Siistijä";
            erno.Profession = "Johtaja";

            erno.Bonus = 800;
            erno.Car = "Seat Ibiza";

            Console.WriteLine(keijo.ToString());
            Console.WriteLine(erno.ToString());
        }
    }
}
