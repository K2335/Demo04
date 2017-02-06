using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Radio
    {
        private bool power;
        private int volume;
        private double frequency;

        // restrictions
        private readonly int maxVol = 9;
        private readonly int minVol = 0;
        private readonly double maxFreq = 26000.0;
        private readonly double minFreq = 2000.0;

        public bool Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;

                if (power == false)
                    Console.WriteLine("Exiting");
                else
                    Console.WriteLine("Radio is now powered on.");
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVol && value >= minVol)
                {
                    volume = value;
                    Console.WriteLine("Volume is now: " + volume);
                }
                if (value < minVol)
                {
                    Console.WriteLine("Volume must be at least 0. Volume is set to 0");
                    volume = minVol;
                }
                if (value > maxVol)
                {
                    Console.WriteLine("Volume maximum is 9, setting volume to max");
                    volume = maxVol;
                }
            }
        }


        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFreq && value >= minFreq)
                {
                    frequency = value;
                    Console.WriteLine("Frequency is set to: " + frequency);
                }
                if (value < minFreq)
                {
                    Console.WriteLine("Frequency must be at least 2000.0 Setting it now..");
                    frequency = minFreq;
                }
                if (value > maxFreq)
                {
                    Console.WriteLine("Frequency cannot be that high. Setting it to max.");
                    frequency = maxFreq;
                }
            }
        }
    }
}
