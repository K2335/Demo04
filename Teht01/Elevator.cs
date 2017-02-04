using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Elevator
    {
        private readonly int maxfloor = 5;


        private int heading;
        public int Heading
        {
            get
            {
                return heading;
            }
            set
            {
                if (value <= maxfloor) heading = value;
                if (value > 0) heading = value;
                else
                {
                    Console.WriteLine("Elevator cannot go there!");
                }
            }
        }


        public int Location { get; set; }


        public void PrintData()
        {
            Console.WriteLine("Heading: " + Heading);
            Console.WriteLine("Location: " + Location);
        }
    }
}
