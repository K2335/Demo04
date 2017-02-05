using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator kone = new Elevator();
            
            while (true) {
                kone.Location = kone.Heading;
                Console.WriteLine("Anna kerros mihin haluat menna: ");
                kone.Heading = int.Parse(Console.ReadLine());
                kone.PrintData();
               
            }
        }
    }
}
