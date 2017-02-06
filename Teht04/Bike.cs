using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Bike : Vehicle
    {
        private bool transmission;
        private string transmissionName;

        public bool Transmission { 
            get
            {
                return transmission;
            }
            set
            {
                transmission = value;
            }
            }

        public string TransmissionName
        {
            get
            {
                return transmissionName;
            }
            set
            {
                transmissionName = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Transmission: " + Transmission + " " + "Transmission Name: " + TransmissionName;
        }
    }
}
