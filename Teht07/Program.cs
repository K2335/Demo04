using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Varsi fatpipe = new Varsi();
            Lapa lapa = new Lapa();

            fatpipe.Name = "Fatpipe";
            lapa.Name = "Fatpipe";
            lapa.Model = "-";
            lapa.Malli = "Wiz";

            fatpipe.Model = "Fat 27";
            lapa.Color = "Pink";

            Console.WriteLine(fatpipe.ToString());
            Console.WriteLine(lapa.ToString());
        }
    }
}
