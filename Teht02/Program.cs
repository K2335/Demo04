using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier kenwood = new Amplifier();

            while (true)
            {
                Console.WriteLine("Give new volume level: ");
                kenwood.Volume = int.Parse(Console.ReadLine());
                kenwood.PrintVolume();
            }
        }
    }
}
