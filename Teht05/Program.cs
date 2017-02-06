using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio sony = new Radio();

            sony.Power = true;
                    
            sony.Volume = 5;

            sony.Frequency = 2400.4;

            sony.Volume = -4;

            sony.Frequency = 20.6;

            sony.Volume = 20;

            sony.Frequency = 801320.5434;

            sony.Volume = 8;

            sony.Frequency = 2670.34;

            sony.Power = false;
        }
    }
}
