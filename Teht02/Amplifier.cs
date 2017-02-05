using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Amplifier
    {
        private readonly int maxVol = 100;
        private readonly int minVol = 0;

        private int vol;

        public int Volume
        {
            get
            {
                return vol;
            }
            set
            {
                if (value <= maxVol) vol = value;
                if (value < minVol)
                {
                    Console.WriteLine("Volume must be at least 0");
                    vol = minVol;
                }
                if (value > maxVol)
                {
                    Console.WriteLine("Volume limit reached!");
                    vol = maxVol;
                }
            }
        }

        public void PrintVolume()
        {
            Console.WriteLine("Volume is now: " + Volume);

        }
    }
}
