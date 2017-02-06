using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Lapa : Varsi
    {
        private string malli;
        private string color;

        public string Malli
        {
            get
            {
                return malli;
            }
            set
            {
                malli = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }


        public override string ToString()
        {
            return base.ToString() + "Blade model: " + Malli + " " + "Color: " + color + " ";
        }
    }
}
