using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Boat : Vehicle
    {
        private string type;
        private int seat;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Seat
        {
            get
            {
                return seat;
            }

            set
            {
                seat = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Type: " + Type + " " + "Seats: " + Seat;
        }
    }
}
