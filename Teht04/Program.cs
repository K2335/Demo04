using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike helkama = new Bike();
            Boat buster = new Boat();

            helkama.Name = "Helkama";
            buster.Name = "Buster";
            

            helkama.Model = "Speedster";
            buster.Model = "A300";

            helkama.ModelYear = 2008;
            buster.ModelYear = 2010;

            helkama.Color = "Yellow";
            buster.Color = "White";

            helkama.Transmission = true;
           
            helkama.TransmissionName = "Nagasaki";

            buster.Type = "Rowboat";

            buster.Seat = 3;

            Console.WriteLine(helkama.ToString());
            Console.WriteLine(buster.ToString());
        }
    }
}
