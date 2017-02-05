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
        private readonly int minfloor = 1;

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
                if (value > maxfloor)
                {
                    Console.WriteLine("Elevator cannot go there!");
                    heading = maxfloor;
                }
                if (value < minfloor)
                {
                    Console.WriteLine("Elevator cannot go there!");
                    heading = minfloor;
                }
            }
        }

        public int Location { get; set; }

        // constructor
        public Elevator()
        {
            Heading = 1;
            Location = 1;
        }
        

        public void PrintData()
        {
            Console.WriteLine("Elevator is now in floor: " + Location);
            Console.WriteLine("Your heading: " + Heading);
            
        }
    }
}
